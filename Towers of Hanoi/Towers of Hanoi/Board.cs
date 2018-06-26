using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Towers_of_Hanoi
{
    class Board
    {
        Disk[,] board; //condition says TWO dimentional array            

        Disk[] disks; //Array of disks

        List<Disk> diskList = null;

        List<DiskMove> movements = null;

        private List<Label> poles = null;

        private const int NUM_DISKS = 4;
        private const int NUM_PEGS = 3;

        public Board()
        {
            board = new Disk[NUM_PEGS, NUM_DISKS];
            movements = new List<DiskMove>();

            //Array of disk objects
            disks = new Disk[NUM_DISKS];
            disks[0] = null;
            disks[1] = null;
            disks[2] = null;
            disks[3] = null;

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  

            board[0, 3] = new Disk();
            board[0, 2] = new Disk();
            board[0, 1] = new Disk();
            board[0, 0] = new Disk();

            //Creating arraylist of movement 
            movements = new List<DiskMove>();
        }

        //
        /// <summary>
        /// Alterntative constructor
        /// </summary>
        /// <param name="d1"></param>
        /// <param name="d2"></param>
        /// <param name="d3"></param>
        /// <param name="d4"></param>
        /// <param name="pls"></param>
        public Board(Disk d1, Disk d2, Disk d3, Disk d4, List<Label> pls)
        {
            poles = pls;

            //Storing into disks list
            diskList = new List<Disk>() { d1, d2, d3, d4 };

            //Storing disk object into board array(Two dimensional arrray) 
            board = new Disk[NUM_PEGS, NUM_DISKS]; //condition says TWO dimentional array  
            board[0, 3] = d1;
            board[0, 2] = d2;
            board[0, 1] = d3;
            board[0, 0] = d4;

            //Arraylist of movement.
            movements = new List<DiskMove>();
        }

        /// <summary>
        /// check if it is valid to begin move
        /// </summary>
        /// <param name="aDisk"></param>
        /// <returns></returns>
        public bool canStartMove(Disk aDisk)
        {
            int curLvl = aDisk.getLevel();
            int topLvl = -1;
            for (int i = 0; i < diskList.Count; i++)
            {
                if (diskList[i].getPegNum() == aDisk.getPegNum())
                {
                    int lvl = diskList[i].getLevel();
                    if (lvl > topLvl)
                    {
                        topLvl = lvl;
                    }
                }
            }

            if (curLvl < topLvl)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// check if it is valid to drop a particular disk on a peg
        /// </summary>
        /// <param name="aDisk"></param>
        /// <param name="aPeg"></param>
        /// <returns></returns>
        public bool canDrop(Disk aDisk, int aPeg)
        {
            int curSize = aDisk.getDiameter();

            for (int i = 0; i < diskList.Count; i++)
            {

                if (diskList[i].getPegNum() == aPeg)
                {
                    int aSize = diskList[i].getDiameter();
                    if (curSize > aSize)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// return a string giving the moves so far, one move per line
        /// </summary>
        /// <returns></returns>
        public string allMovesAsString()
        {
            string logs = "";
            for (int i = 0; i < movements.Count; i++)
            {
                logs += movements[i].AsText() + "\r\n";
            }
            return logs;
        }

        /// <summary>
        /// display current position of the disks
        /// </summary>
        public void Display()
        {
            for (int i = 0; i < diskList.Count; i++)
            {
                Disk curDisk = diskList[i];

                Label curlbl = curDisk.getLabel();

                int poleIdx = curDisk.getPegNum();

                int aLeft = (poles[poleIdx].Left + (poles[poleIdx].Width / 2)) - (curlbl.Width / 2);
                int aTop = (poles[poleIdx].Top + poles[poleIdx].Height) - ((curDisk.getLevel() + 1) * curlbl.Height);

                curlbl.Left = aLeft;
                curlbl.Top = aTop;

                curlbl.BringToFront();

            }
        }

        /// <summary>
        /// use lable to get curDisk
        /// </summary>
        /// <param name="aLabel"></param>
        /// <returns></returns>
        public Disk FindDisk(Label aLabel)
        {
            for (int idx = 0; idx < diskList.Count; idx++)
            {
                if (diskList[idx].getLabel().Name == aLabel.Name)
                {
                    return diskList[idx];
                }
            }
            return null;
        }

        /// <summary>
        /// use pole id to get current pole has how many disks
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns>
        public int getLevel(int ind)
        {
            int curPoleLevel = 0;
            for (int i = 0; i < diskList.Count; i++)
            {

                if (diskList[i].getPegNum() == ind)
                {
                    curPoleLevel++;
                }
            }
            return curPoleLevel;
        }

        /// <summary>
        /// use disk lable to get current pole has how many disks
        /// </summary>
        /// <param name="curLable"></param>
        /// <returns></returns>
        public int getDiskLevel(Label curLable)
        {
            Disk curDisk = FindDisk(curLable);
            if (curDisk == null)
            {
                return -1;
            }
            return getDiskLevel(curDisk);
        }

        /// <summary>
        /// use disk to get current pole has how many disks
        /// </summary>
        /// <param name="curDisk"></param>
        /// <returns></returns>
        private int getDiskLevel(Disk curDisk)
        {
            for (int i = 0; i < diskList.Count; i++)
            {
                if (diskList[i].getLabel().Name == curDisk.getLabel().Name)
                {
                    return i;
                }
            }
            return -1;
        }


        /// <summary>
        /// return the index number of panels or poles from a control's name,
        // return -1 when the ctlname does not found.
        /// </summary>
        /// <param name="ctlname"></param>
        /// <returns></returns>
        public int getIndexByName(string ctlname)
        {
            for (int i = 0; i < poles.Count; i++)
            {
                if (poles[i].Name == ctlname)
                {
                    return i;
                }
            }

            return -1;
        }


        /// <summary>
        /// get curDisk index by lable
        /// </summary>
        /// <param name="lblCurDisk"></param>
        /// <returns></returns>
        public int getDiskIdxByLbl(Label lblCurDisk)
        {
            int curDiskIdx = -1;
            for (int i = 0; i < diskList.Count; i++)
            {
                if (diskList[i].getLabel().Name == lblCurDisk.Name)
                {
                    curDiskIdx = i;

                }
            }
            return curDiskIdx;
        }

        /// <summary>
        /// return the disk for index idx
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public Disk getDiskByIndex(int idx)
        {
            if (idx < 0 || idx > (diskList.Count - 1))
            {
                return null;
            }
            return diskList[idx];
        }

        /// <summary>
        /// to check disk move is done or not
        /// </summary>
        /// <returns></returns>
        internal bool diskMoveIsDone()
        {
            int diskCount = 0;
            for (int i = 0; i < diskList.Count; i++)
            {
                if (diskList[i].getPegNum() == 2)
                {
                    diskCount++;
                    if (diskCount == 4)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// restart a new game
        /// </summary>
        internal void reStart()
        {

            int curPoleLevel = 0;

            for (int i = 0; i < diskList.Count; i++)
            {
                Label curDisk = diskList[i].getLabel();

                int aLeft = (poles[0].Left + (poles[0].Width / 2)) - (curDisk.Width / 2);
                int aTop = (poles[0].Top + poles[0].Height) - ((curPoleLevel + 1) * curDisk.Height);

                curDisk.Left = aLeft;
                curDisk.Top = aTop;

                curDisk.BringToFront();

                diskList[i].setPegNum(0);
                diskList[i].setLevel(curPoleLevel);
                curPoleLevel++;
            }

            //Reallocate elements 
            board[0, 3] = diskList[0]; //Peg 1/Level4 
            board[0, 2] = diskList[1]; //Peg 1/Level3 
            board[0, 1] = diskList[2]; //Peg 1/Level2
            board[0, 0] = diskList[3]; //Peg 1/Level1 

            movements.Clear();
        }

        /// <summary>
        /// set disk move action and save move statment into diskmove
        /// </summary>
        /// <param name="curDisk"></param>
        /// <param name="poleIdx"></param>
        public void setDiskMove(Disk curDisk, int poleIdx)
        {
            int poleLvl = getLevel(poleIdx);
            curDisk.setPegNum(poleIdx);
            curDisk.setLevel(poleLvl);
            movements.Add(new DiskMove(getDiskLevel(curDisk), poleIdx));
        }

        /// <summary>
        /// return current movements in order
        /// </summary>
        /// <returns></returns>
        public List<DiskMove> getMovements()
        {
            List<DiskMove> inOrderMoves = new List<DiskMove>();
            for (int i = 0; i < movements.Count; i++)
            {
                inOrderMoves.Add(new DiskMove(movements[i].getDiskInd(), movements[i].getPegInd()));
            }
            return inOrderMoves;

        }

        /// <summary>
        /// save current game's status
        /// </summary>
        /// <param name="fileName"></param>
        internal void saveGame(string fileName)
        {
            if (fileName == "")
            {
                return;
            }
            string movesText = "";
            for (int i = 0; i < movements.Count; i++)
            {
                movesText += movements[i].commaText() + "\n";
            }

            StreamWriter sw = new StreamWriter(fileName);
            sw.Write(movesText);
            sw.Close();
        }

        /// <summary>
        /// load game for local 
        /// </summary>
        /// <param name="fileName"></param>
        internal void loadGame(string fileName)
        {
            if (fileName == "")
            {
                return;
            }
            string movesText = "";

            StreamReader sr = new StreamReader(fileName);

            List<DiskMove> moves = new List<DiskMove>();
            while (true)
            {
                movesText = sr.ReadLine();
                if (movesText == null)
                {
                    break;
                }
                moves.Add(new DiskMove(movesText));
            }
            sr.Close();

            resetGame(moves);
        }

        /// <summary>
        /// reset the game status
        /// </summary>
        /// <param name="moves"></param>
        private void resetGame(List<DiskMove> moves)
        {
            reStart();
            for (int i = 0; i < moves.Count; i++)
            {
                setDiskMove(diskList[moves[i].getDiskInd()], moves[i].getPegInd());

            }

            Display();

        }
    }
}
