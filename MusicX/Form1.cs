using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using NAudio;
using NAudio.Wave;


namespace MusicX
{
    public partial class FrmMusicMain : Form
    {
        // NAudio
        AudioFileReader audioFileReader;

        private AudioPlayer audioPlayer;


        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;
        
        //PlayerImport userPlay = new PlayerImport();
        string[] files;
        string[] path;
        public FrmMusicMain()
        {
            InitializeComponent();
            
            
        }

        //Form Loading
        private void FrmMusicMain_Load(object sender, EventArgs e)
        {
            //save checked password to what properties have as default option
            Text = Properties.Settings.Default.TxtUsername;
            CBoxSavePassword.Checked = Properties.Settings.Default.CboxSavePassword;
            TxtUsername.Text = Properties.Settings.Default.TxtUsername;

            VolumeTrackBar.Minimum = 0;
            VolumeTrackBar.Maximum = 100;

            
            //remember password if user checks "Remember Password" CheckBox
            if (CBoxSavePassword.Checked)
            {
                TxtPassword.Text = Properties.Settings.Default.TxtPassword;
            }

            BtnPause.Visible = false;

            //when main loads set login page to not visible
            LblUsernameLogin.Visible = false;
            LblPasswordLogin.Visible = false;
            TxtUsername.Visible = false;
            TxtPassword.Visible = false;
            CBoxSavePassword.Visible = false;
            BtnLoginUserPass.Visible = false;
            BtnLogin.Text = "Login";
           
        }

        

        private void BtnOpenFiles_Click(object sender, EventArgs e)
        {
            //make sure listbox is visible to the user
            ListBox.Visible = true;

            //when open file loads set login page to not visible
            LblUsernameLogin.Visible = false;
            LblPasswordLogin.Visible = false;
            TxtUsername.Visible = false;
            TxtPassword.Visible = false;
            CBoxSavePassword.Visible = false;
            BtnLoginUserPass.Visible = false;
            BtnLogin.Text = "Login";


            OpenFileDialog songChoice = new OpenFileDialog();
            //filter only mp3 filetypes in files
            songChoice.Filter = "Mp3 File(*.mp3)|*.mp3";

            //select more than one track    
            songChoice.Multiselect = true;

            if(songChoice.ShowDialog() == DialogResult.OK)
            {
                files = songChoice.SafeFileNames;
                path = songChoice.FileNames;

                //adding items to list
                for(int index = 0; index < files.Length; index++)
                {
                    ListBox.Items.Add(files[index]);
                }

                //highlights current song playing
                ListBox.SetSelected(0, true);

                //dispose function to get rid of the current song in WaveStream NAudio
                DisposeWave();

                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(songChoice.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                
                LblTest.Text = path[0];
                LblNowPlaying.Text = files[0];
                //play song
                output.Play();

                //hide the play button
                BtnPlay.Visible = false;
                BtnPause.Visible = true;
            }
        }
        //Button to play music 
        private void BtnPlay_Click(object sender, EventArgs e)
        {
            //caught NullException
            //handlings state if there is no sound
            if (output == null)
            {
                MessageBox.Show("Click local files to play a song.", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { //if Playback state is paused
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    output.Play();
                    //if playback state is playing current song
                }
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                }

                //hide buttons and show
                BtnPlay.Visible = false;
                BtnPause.Visible = true;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //DisposeWave();
            //string songChoice = ListBox.SelectedItem.ToString();
            //NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(songChoice));
            //stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            //output = new NAudio.Wave.DirectSoundOut();
            //output.Init(stream);

            LblTest.Text = path[0];
            LblNowPlaying.Text = files[0];
            //play song
            //output.Play();


            //show current song onto a label
            LblNowPlaying.Text = ListBox.Text;
        }
        
        
        
        //Button to pause music
        private void BtnPause_Click(object sender, EventArgs e)
        {
            if(output != null)
            {
                if(output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Pause();
                }
                else if(output.PlaybackState == NAudio.Wave.PlaybackState.Paused)
                {
                    output.Play();
                }
            }

            //hide buttons
            BtnPause.Visible = false;
            BtnPlay.Visible = true;

        }

        public void SetVolume(float value)
        {
            audioFileReader.Volume = value;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //open dialog for settings form
            FrmSettings options = new FrmSettings();

            options.ShowDialog();
        }

        //Save most recent listbox playlist in files
        private void BtnSaveSongs_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for(int j = 0; j< ListBox.Items.Count; j++)
                {
                    writer.WriteLine(ListBox.Items[j]);
                }

                writer.Close();
            }
            dlg.Dispose();
        }



        //============LOGING CONFIGURATION================
        private void BtnLogin_Click(object sender, EventArgs e)
        {

            //hides visibility of login page
            if (ListBox.Visible == true)
            {
                ListBox.Visible = false;
                LblUsernameLogin.Visible = true;
                LblPasswordLogin.Visible = true;
                TxtUsername.Visible = true;
                TxtPassword.Visible = true;
                CBoxSavePassword.Visible = true;
                BtnLoginUserPass.Visible = true;
                BtnLogin.Text = "Close Login";
            }
            else
            {
                //show visibility of login page if listbox isn't visible
                ListBox.Visible = true;
                LblUsernameLogin.Visible = false;
                LblPasswordLogin.Visible = false;
                TxtUsername.Visible = false;
                TxtPassword.Visible = false;
                CBoxSavePassword.Visible = false;
                BtnLoginUserPass.Visible = false;
                BtnLogin.Text = "Login";
            }
        }
        //Checks User Input Valid
        private void BtnLoginUserPass_Click(object sender, EventArgs e)
        {
            //
            LblProfile.Text = "USER";
            if (TxtPassword.Text.Length >= 3 && (TxtUsername.Text.Length >= 3 && TxtUsername.Text.Length <= 10))
            {
                LblProfile.Text = TxtUsername.Text;
            }
            else
            {
                if(MessageBox.Show("Insufficient detail for Login.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                }
            }

            //if checkbox is not checked to save user's password for next form load
            //then text is blank
            if (CBoxSavePassword.Checked == false)
            {
                TxtUsername.Text = "";
                TxtPassword.Text = "";
            } 
            
        }

        //Function to dispose the current mp3 file
        private void DisposeWave()
        {
            if(output != null)
            {
                if(output.PlaybackState == NAudio.Wave.PlaybackState.Playing)
                {
                    output.Dispose();
                    output.Stop();
                }
                if(stream != null)
                {
                    stream.Dispose();
                    stream = null;
                }
            }
        }

        

        private void CBoxSavePassword_CheckedChanged(object sender, EventArgs e)
        {
            if(CBoxSavePassword.Checked == true)
            {

            }
        }

        private void LblNowPlaying_Click(object sender, EventArgs e)
        {
            
        }

        private void LblProfile_Click(object sender, EventArgs e)
        {

        }

        private void VolumeTrackBar_Scroll(object sender, EventArgs e)
        {
            //set the label to amount value 
            LblVolumeCount.Text = VolumeTrackBar.Value.ToString();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {

            if (output == null)
            {
                MessageBox.Show("No more songs in playlist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ListBox.SelectedIndex != ListBox.Items.Count - 1)
            {
                //counter for get selected index in listbox
                int count = 0;
                ListBox.SetSelected(count + 1, true);

                int nextIndex = ListBox.SelectedIndex + 1;
                DisposeWave();

                OpenFileDialog forwardSong = new OpenFileDialog();
                //getting the string of the next song
                string nextSong = ListBox.Items[nextIndex].ToString();
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(forwardSong.FileName));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);

                LblTest.Text = path[0];
                LblNowPlaying.Text = files[0];

                //play output
                output.Play();

                
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if(ListBox.SelectedIndex > 0)
            {
                ListBox.SelectedIndex = ListBox.SelectedIndex - 1;
            }
            
        }

        private void LblNowPlaying_MouseHover(object sender, EventArgs e)
        {
            
        }
        
        //Mouse Hover
        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            //from System.Drawing library
            //changing the forecolor 
            BtnLogin.ForeColor = SystemColors.ControlLightLight;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            //from System.Drawing library
            //changing the forecolor for mouse leave event 
            BtnLogin.ForeColor = SystemColors.ControlLight;
        }

        private void BtnSettings_MouseHover(object sender, EventArgs e)
        {
            BtnSettings.ForeColor = SystemColors.ControlLightLight;
        }

        private void BtnSettings_MouseLeave(object sender, EventArgs e)
        {
            BtnSettings.ForeColor = SystemColors.ControlLight;
        }

        private void ProgressMax_Click(object sender, EventArgs e)
        {
            
        }

        //Form Closing
        private void FrmMusicMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();

            //save preferences for CheckBoxes and Username to save for next time the form is opened
            Properties.Settings.Default.CboxSavePassword = CBoxSavePassword.Checked;
            Properties.Settings.Default.TxtUsername = TxtUsername.Text;
            Properties.Settings.Default.Save();
        }
    }
}
