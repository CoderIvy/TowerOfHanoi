using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Towers_of_Hanoi
{
    public partial class MainForm : Form
    {
        // The board
        private Board aBoard = null;

        // use for convert dropping in panel to dropping in pole
        private List<Label> poles = new List<Label>();

        // current selected/moving lable and disk
        private Label lblDiskOnMouseDown = null;

        // destination of drop
        private Label destPole = null;

        // use for playback animation
        private List<DiskMove> playbacks = null;

        private int playbackIndex = -1;


        public MainForm()
        {
            InitializeComponent();
            poles = new List<Label>() { lblPole0, lblPole1, lblPole2 };
            aBoard = boardInit();
            txtTips.Text = "Info: Game started....";

        }

        /// <summary>
        ///  initial new board
        /// </summary>
        /// <returns></returns>
        private Board boardInit()
        {
            Board board = new Board(
            (new Disk(lblDisk0, 255, 0, 0)),
            (new Disk(lblDisk1, 255, 1, 0)),
            (new Disk(lblDisk2, 255, 2, 0)),
            (new Disk(lblDisk3, 255, 3, 0)),
            poles
            );

            return board;
        }

        /// <summary>
        /// exit the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///  all disk mouse down event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllDisk_MouseDown(object sender, MouseEventArgs e)
        {
            lblDiskOnMouseDown = (sender as Label);
            Disk curDisk = aBoard.FindDisk(lblDiskOnMouseDown);

            if (curDisk == null)
            {
                txtTips.Text = "Error: Disk does not exist.";
                return;
            }

            if (aBoard.canStartMove(curDisk) == false)
            {
                txtTips.Text = "Error: You can only move the disk which on the top.";
                return;
            }

            DragDropEffects result = lblDiskOnMouseDown.DoDragDrop(lblDiskOnMouseDown, DragDropEffects.All);
            if (result != DragDropEffects.None)
            {
                
                int destPoleIdx = Convert.ToInt32(destPole.Name.Substring(7, 1));
                int curDiskIdx = aBoard.getDiskIdxByLbl(lblDiskOnMouseDown);
                
                //move disk to new pole
                MoveDisk(curDisk, destPoleIdx);

            }
        }

        /// <summary>
        /// move disk to destin pole enter event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllPole_DragEnter(object sender, DragEventArgs e)
        {
            
            destPole = (sender as Label);
            Disk curDisk = aBoard.FindDisk(lblDiskOnMouseDown);
            int poleIdx = Convert.ToInt32(destPole.Name.Substring(7, 1));

            //destPole has no disk
            if (aBoard.getLevel(poleIdx) == 0)
            {
                e.Effect = DragDropEffects.All;
                return;
            }

            //current disk is bigger than original disk 
            if (aBoard.canDrop(curDisk, poleIdx) == false)
            {
                e.Effect = DragDropEffects.None;
                txtTips.Text = "Error: Can not put a bigger disk on the top.";
                return;
            }
            e.Effect = DragDropEffects.All;

        }

        /// <summary>
        /// all disk drop event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AllPole_DragDrop(object sender, DragEventArgs e)
        {
            destPole = (sender as Label);
        }

        /// <summary>
        /// move disk to destine position
        /// </summary>
        /// <param name="curDisk"></param>
        /// <param name="poleIdx"></param>
        private void MoveDisk(Disk curDisk, int poleIdx)
        {
            int curPoleLevel = aBoard.getLevel(poleIdx);

            if (curPoleLevel > 0 && aBoard.canDrop(curDisk, poleIdx) == false)
            {
                txtTips.Text = "Error: Can not put a bigger disk on the top.";
                return;
            }

            aBoard.setDiskMove(curDisk, poleIdx);

            aBoard.Display();

            showGameStatus("Info: Move " + lblDiskOnMouseDown.Text + " to pole " + poleIdx);

            txtLogs.Text = aBoard.allMovesAsString();

            if (aBoard.diskMoveIsDone())
            {
                if (aBoard.getMovements().Count <= 15)
                {
                    txtTips.Text = "Congratuation!! You have successfully completed the game with the minimum number of moves.";

                }
                else
                {
                    txtTips.Text = "Congratuation!! You finished the game successfully but not with minumn number of moves.";
                }
                MessageBox.Show(txtTips.Text, "Congratuation");
            }

        }

        /// <summary>
        /// show current game info
        /// </summary>
        /// <param name="str"></param>
        private void showGameStatus(string str)
        {
            int moveCount = aBoard.getMovements().Count;

            // 15 = 2 ^ 4 - 1;
            txtStep.Text = moveCount.ToString() + "/15";

            txtLogs.Text = aBoard.allMovesAsString();

            if (str != "")
            {
                txtTips.Text = str;
            }
        }

        /// <summary>
        /// restart a new game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestart_Click(object sender, EventArgs e)
        {
            txtLogs.Clear();
            aBoard.reStart();
            showGameStatus("Info: Game reseted!");
        }

        /// <summary>
        /// save current game status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<DiskMove> moveCount = aBoard.getMovements();
            if (moveCount.Count == 0)
            {
                txtTips.Text = "Error: There is not moves to save.";
                MessageBox.Show(txtTips.Text, "Error");
                return;
            }

            if (saveFileDlg.FileName == "")
            {
                saveFileDlg.FileName = "saveHanoi.sf";
            }

            if (saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                //save game to local
                aBoard.saveGame(saveFileDlg.FileName);
                txtTips.Text = "Info: current game movements saved to " + saveFileDlg.FileName;
            }

        }

        /// <summary>
        /// load saved game 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDlg.FileName == "")
            {
                openFileDlg.FileName = "saveHanoi.sf";
            }
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                aBoard.loadGame(openFileDlg.FileName);

            }

            showGameStatus("Info: game restored from " + openFileDlg.FileName);
        }

        /// <summary>
        /// playback moved steps
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnimation_Click(object sender, EventArgs e)
        {
            playbacks = aBoard.getMovements();
            if (playbacks.Count == 0)
            {
                MessageBox.Show("can not playback while not existed movements", "Error");
                return;
            }

            btnRestart_Click(sender, e);

            playbackIndex = 0;

            txtTips.Text = "Info: playback started ...";
     
            // need: using System.Timers;
            playbackTimer.Start();
        }

        /// <summary>
        /// playback the save movements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void playbackTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {

            if (playbackIndex >= playbacks.Count)
            {
                playbackTimer.Stop();
                return;
            }

            int diskIdx = playbacks[playbackIndex].getDiskInd();
            int dstIdx = playbacks[playbackIndex].getPegInd();

            playbackIndex += 1;
            MoveDisk(aBoard.getDiskByIndex(diskIdx), dstIdx);
         
        }
    }
}
