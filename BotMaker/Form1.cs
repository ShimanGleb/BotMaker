using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BotMaker
{
    public partial class MainWindow : Form
    {
        public static List<Command> actions = new List<Command>();
        public static List<Repeater> repeaters = new List<Repeater>();

        System.Threading.Thread botThread = new System.Threading.Thread(() =>
        {
            while (true)
            {
                for (int i = 0; i < repeaters.Count; i++)
                {
                    repeaters[i].RestoreRepeats();
                }
                for (int i = 0; i < actions.Count; i++)
                {
                    actions[i].PerformAction();
                    for (int j = repeaters.Count - 1; j >= 0; j--)
                    {
                        if (repeaters[j].lastCommand == i && repeaters[j].leftRepeats!=0)
                        {
                            for (int k = 1; k <= repeaters[j].influencedRepeaters; k++)
                            {
                                repeaters[j + k].RestoreRepeats();
                            }
                            repeaters[j].leftRepeats--;
                            i = repeaters[j].startingCommand-1;
                            break;
                        }
                    }
                }
            }
        });

        public MainWindow()
        {
            InitializeComponent();
            ActionBox.SelectedItem = ActionBox.Items[0];
            saveFileDialog1.Filter ="Text files (*.txt)|*.txt";
            openFileDialog1.Filter = "Text files (*.txt)|*.txt";            
        }

        private void AddPoint()
        {
            int xPosition = 0;
            int yPosition = 0;

            Form setterForm = new Form();
            Label warner = new Label();
            warner.Location = new System.Drawing.Point(30, 10);
            warner.Font = new Font(warner.Font.Name, 10, warner.Font.Style);
            warner.AutoSize = true;
            warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after 3  second(s).";


            setterForm.Size = new System.Drawing.Size(480, 100);
            setterForm.Controls.Add(warner);
            setterForm.Text = "WARNING!";
            setterForm.Show();

            int timeRemaining = 3;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((object newSender, EventArgs newE) =>
            {
                timeRemaining--;
                warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after " + timeRemaining + " second(s).";
                System.Threading.Thread.Sleep(1000);
                if (timeRemaining <= 0)
                {
                    xPosition = Cursor.Position.X;
                    yPosition = Cursor.Position.Y;
                    warner.Text = "Cursor position successfully added.";
                    UpdateDataGrid("Point(" + xPosition + ',' + yPosition + ')');                    

                    setterForm.Close();
                    timer.Stop();
                }
                xPosition = Cursor.Position.X;
                yPosition = Cursor.Position.Y;
            });
            timer.Interval = 1;
            timer.Start();
        }

        private void AddDrag()
        {
            int xPosition = 0;
            int yPosition = 0;

            Form setterForm = new Form();
            Label warner = new Label();
            warner.Location = new System.Drawing.Point(30, 10);
            warner.Font = new Font(warner.Font.Name, 10, warner.Font.Style);
            warner.AutoSize = true;
            warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after 3  second(s).";


            setterForm.Size = new System.Drawing.Size(480, 100);
            setterForm.Controls.Add(warner);
            setterForm.Text = "WARNING!";
            setterForm.Show();

            int timeRemaining = 3;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((object newSender, EventArgs newE) =>
            {
                timeRemaining--;
                warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after " + timeRemaining + " second(s).";
                System.Threading.Thread.Sleep(1000);
                if (timeRemaining <= 0)
                {
                    xPosition = Cursor.Position.X;
                    yPosition = Cursor.Position.Y;
                    warner.Text = "Cursor position successfully added.";
                    UpdateDataGrid("Drag(" + xPosition + ',' + yPosition + ')');

                    setterForm.Close();
                    timer.Stop();
                }
                xPosition = Cursor.Position.X;
                yPosition = Cursor.Position.Y;
            });
            timer.Interval = 1;
            timer.Start();
        }

        private void AddClick()
        {
            int xPosition = 0;
            int yPosition = 0;

            Form setterForm = new Form();
            Label warner = new Label();
            warner.Location = new System.Drawing.Point(30, 10);
            warner.Font = new Font(warner.Font.Name, 10, warner.Font.Style);
            warner.AutoSize = true;
            warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after 3  second(s).";


            setterForm.Size = new System.Drawing.Size(480, 100);
            setterForm.Controls.Add(warner);
            setterForm.Text = "WARNING!";
            setterForm.Show();

            int timeRemaining = 3;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((object newSender, EventArgs newE) =>
            {
                timeRemaining--;
                warner.Text = "Please, set cursor to requested position \r\nProgram will automatically read cursor position after " + timeRemaining + " second(s).";
                System.Threading.Thread.Sleep(1000);
                if (timeRemaining <= 0)
                {
                    xPosition = Cursor.Position.X;
                    yPosition = Cursor.Position.Y;
                    warner.Text = "Cursor position successfully added.";
                    UpdateDataGrid("Click(" + xPosition + ',' + yPosition + ')');

                    setterForm.Close();
                    timer.Stop();
                }
                xPosition = Cursor.Position.X;
                yPosition = Cursor.Position.Y;
            });
            timer.Interval = 1;
            timer.Start();
        }

        private void AddWait()
        {
            Form setterForm = new Form();

            Label hoursLabel = new Label();
            hoursLabel.Text = "Hours:";
            hoursLabel.AutoSize = true;
            hoursLabel.Location = new System.Drawing.Point(10, 10);
            hoursLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            Label hoursFromLabel = new Label();
            hoursFromLabel.Text = "from";
            hoursFromLabel.AutoSize = true;
            hoursFromLabel.Location = new System.Drawing.Point(60, 10);
            hoursFromLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            Label minutesFromLabel = new Label();
            minutesFromLabel.Text = "from";
            minutesFromLabel.AutoSize = true;
            minutesFromLabel.Location = new System.Drawing.Point(70, 40);
            minutesFromLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            Label secondsFromLabel = new Label();
            secondsFromLabel.Text = "from";
            secondsFromLabel.AutoSize = true;
            secondsFromLabel.Location = new System.Drawing.Point(80, 70);
            secondsFromLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            setterForm.Controls.Add(hoursFromLabel);
            setterForm.Controls.Add(minutesFromLabel);
            setterForm.Controls.Add(secondsFromLabel);

            NumericUpDown hoursFrom = new NumericUpDown();
            hoursFrom.Minimum = 0;
            hoursFrom.Maximum = 24;
            hoursFrom.Location = new System.Drawing.Point(100, 10);
            hoursFrom.Size = new System.Drawing.Size(40, 10);

            Label minutesLabel = new Label();
            minutesLabel.Text = "Minutes:";
            minutesLabel.AutoSize = true;
            minutesLabel.Location = new System.Drawing.Point(10, 40);
            minutesLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            NumericUpDown minutesFrom = new NumericUpDown();
            minutesFrom.Minimum = 0;
            minutesFrom.Maximum = 60;
            minutesFrom.Location = new System.Drawing.Point(115, 40);
            minutesFrom.Size = new System.Drawing.Size(40, 10);

            Label secondsLabel = new Label();
            secondsLabel.Text = "Seconds:";
            secondsLabel.AutoSize = true;
            secondsLabel.Location = new System.Drawing.Point(10, 70);
            secondsLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            NumericUpDown secondsFrom = new NumericUpDown();
            secondsFrom.Minimum = 0;
            secondsFrom.Maximum = 60;
            secondsFrom.Location = new System.Drawing.Point(120, 70);
            secondsFrom.Size = new System.Drawing.Size(40, 10);

            Label hoursToLabel = new Label();
            hoursToLabel.Text = "to";
            hoursToLabel.AutoSize = true;
            hoursToLabel.Location = new System.Drawing.Point(150, 10);
            hoursToLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            Label minutesToLabel = new Label();
            minutesToLabel.Text = "to";
            minutesToLabel.AutoSize = true;
            minutesToLabel.Location = new System.Drawing.Point(160, 40);
            minutesToLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            Label secondsToLabel = new Label();
            secondsToLabel.Text = "to";
            secondsToLabel.AutoSize = true;
            secondsToLabel.Location = new System.Drawing.Point(170, 70);
            secondsToLabel.Font = new Font(hoursLabel.Font.Name, 10, hoursLabel.Font.Style);

            setterForm.Controls.Add(hoursToLabel);
            setterForm.Controls.Add(minutesToLabel);
            setterForm.Controls.Add(secondsToLabel);

            NumericUpDown hoursTo = new NumericUpDown();
            hoursTo.Minimum = 0;
            hoursTo.Maximum = 60;
            hoursTo.Location = new System.Drawing.Point(180, 10);
            hoursTo.Size = new System.Drawing.Size(40, 10);

            NumericUpDown minutesTo = new NumericUpDown();
            minutesTo.Minimum = 0;
            minutesTo.Maximum = 60;
            minutesTo.Location = new System.Drawing.Point(190, 40);
            minutesTo.Size = new System.Drawing.Size(40, 10);

            NumericUpDown secondsTo = new NumericUpDown();
            secondsTo.Minimum = 0;
            secondsTo.Maximum = 60;
            secondsTo.Location = new System.Drawing.Point(200, 70);
            secondsTo.Size = new System.Drawing.Size(40, 10);

            setterForm.Controls.Add(hoursTo);
            setterForm.Controls.Add(minutesTo);
            setterForm.Controls.Add(secondsTo);

            Button submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.Location = new System.Drawing.Point(10, 100);
            submitButton.Size = new System.Drawing.Size(50, 30);
            submitButton.Click += new EventHandler((object newSender, EventArgs newE) =>
            {
                UpdateDataGrid("Wait(" + hoursFrom.Value + '-' + hoursTo.Value + ':' + minutesFrom.Value + '-' + minutesTo.Value + ':' + secondsFrom.Value + '-' + secondsTo.Value + ')');
                setterForm.Close();
            });

            hoursFrom.ValueChanged += new EventHandler((object newSender, EventArgs newE) =>
            {
                hoursTo.Minimum = hoursFrom.Value;                
            });

            minutesFrom.ValueChanged += new EventHandler((object newSender, EventArgs newE) =>
            {
                minutesTo.Minimum = minutesFrom.Value;
            });

            secondsFrom.ValueChanged += new EventHandler((object newSender, EventArgs newE) =>
            {
                secondsTo.Minimum = secondsFrom.Value;
            });

            setterForm.Size = new System.Drawing.Size(300, 200);
            setterForm.Controls.Add(hoursLabel);
            setterForm.Controls.Add(hoursFrom);
            setterForm.Controls.Add(minutesLabel);
            setterForm.Controls.Add(minutesFrom);
            setterForm.Controls.Add(secondsLabel);
            setterForm.Controls.Add(secondsFrom);
            setterForm.Controls.Add(submitButton);
            setterForm.Text = "Set waiting time";
            setterForm.Show();
        }

        private void AddRepeater()
        {
            Form setterForm = new Form();
            setterForm.Size = new System.Drawing.Size(200,100);

            Label repeatLabel = new Label();
            repeatLabel.Text = "Number of repeats:";
            repeatLabel.AutoSize = true;
            repeatLabel.Location = new System.Drawing.Point(10,15);

            NumericUpDown repeatTimes = new NumericUpDown();
            repeatTimes.Minimum = 2;
            repeatTimes.Maximum = 999;
            repeatTimes.Size = new System.Drawing.Size(50,10);
            repeatTimes.Location = new System.Drawing.Point(120,10);

            Button submitButton = new Button();
            submitButton.Text = "Submit";
            submitButton.AutoSize = true;
            submitButton.Location = new System.Drawing.Point(10,35);
            submitButton.Click += new EventHandler((object newSender, EventArgs newE) =>
            {
                if (insertAfterRadioButton.Checked == true)
                {
                    UpdateDataGrid("}");
                    UpdateDataGrid("{");
                    UpdateDataGrid("Repeat(" + repeatTimes.Value + ')');                                        
                }
                else
                {
                    UpdateDataGrid("Repeat(" + repeatTimes.Value + ')');                    
                    UpdateDataGrid("{");
                    UpdateDataGrid("}");
                }                
                setterForm.Close();
            });

            setterForm.Controls.Add(repeatLabel);
            setterForm.Controls.Add(repeatTimes);
            setterForm.Controls.Add(submitButton);
            setterForm.Show();
        }

        public void UpdateDataGrid(string action)
        {            
            if (insertBeforeRadioButton.Checked == true)
            {
                ActionListGrid.Rows.Insert(ActionListGrid.SelectedRows[0].Index, action);
            }

            if (insertAfterRadioButton.Checked == true)
            {
                ActionListGrid.Rows.Insert(ActionListGrid.SelectedRows[0].Index+1,action);                            
            }

            if (InsetInEndRadioButton.Checked == true)
            {
                ActionListGrid.Rows.Add();
                ActionListGrid[0, ActionListGrid.Rows.Count - 1].Value = action;
            }
        }

        private void EnableEditing()
        {
            CheckCursorButton.Enabled = true;
            RemoveActionButton.Enabled = true;
        }

        private void AddActionButton_Click(object sender, EventArgs e)
        {
            string action=ActionBox.SelectedItem.ToString().Split('-')[0];
            switch (action)
            {
                case "Point ": AddPoint(); break;
                case "Drag ": AddDrag(); break;
                case "Click ": AddClick(); break;
                case "Wait ": AddWait(); break;
                case "Repeat ": AddRepeater(); break;
            } 
            EnableEditing();
        }

        private void RunBotButton_Click(object sender, EventArgs e)
        {
            RunBotButton.Enabled = false;
            StopBotButton.Enabled = true;
            actions.Clear();
            repeaters.Clear();
            int lastRepeater = -1;
            CommandParser parser = new CommandParser();
            for (int i = 0; i < ActionListGrid.Rows.Count; i++)
            {
                
                string command = ActionListGrid[0, i].Value.ToString();
                if (command=="}")
                {
                    if (actions.Count - 1 < repeaters[lastRepeater].startingCommand)
                    {
                        repeaters.Remove(repeaters[lastRepeater]);
                    }
                    else
                    {
                        repeaters[lastRepeater].lastCommand = actions.Count - 1;
                        repeaters[lastRepeater].influencedRepeaters = repeaters.Count-1-lastRepeater;
                        lastRepeater--;
                    }
                    if (ActionListGrid.Rows.Count == i+1)
                    {
                        break;
                    }                    
                }
                if (command.Split('(')[0] == "Repeat")
                {
                    i++;
                    Repeater repeater = new Repeater();
                    repeater.SetRepeatsAmount(Convert.ToInt32(command.Split('(')[1].Split(')')[0])-1);
                    repeater.startingCommand = actions.Count;
                    lastRepeater++;
                    repeaters.Add(repeater);
                }
                if (command.Split('(')[0] != "Repeat" && command != "}")
                { 
                    Command action;
                    try
                    {
                        action = parser.Parse(command);
                        actions.Add(action);
                    }
                    catch { }
                }
            }


            Form setterForm = new Form();
            Label warner = new Label();
            warner.Location = new System.Drawing.Point(30, 10);
            warner.Font = new Font(warner.Font.Name, 10, warner.Font.Style);
            warner.AutoSize = true;
            warner.Text = "Bot will start running after 3  second(s).";

            setterForm.Size = new System.Drawing.Size(480, 100);
            setterForm.Controls.Add(warner);
            setterForm.Text = "WARNING!";

            int timeRemaining = 3;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((object newSender, EventArgs newE) =>
            {
                timeRemaining--;
                warner.Text = "Bot will start running after " + timeRemaining + " second(s).";
                System.Threading.Thread.Sleep(1000);
                if (timeRemaining <= 0)
                {
                    setterForm.Close();
                    timer.Stop();
                }
            });
            timer.Interval = 1;
            timer.Start();

            setterForm.ShowDialog();
            
            botThread.Start();
                     
        }

        private void StopBotButton_Click(object sender, EventArgs e)
        {            
            botThread.Abort();
            RunBotButton.Enabled = true;
            StopBotButton.Enabled = false;
            botThread = new System.Threading.Thread(() =>
            {
                while (true)
                {
                    for (int i = 0; i < actions.Count; i++)
                    {
                        actions[i].PerformAction();
                    }
                }
            });
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionListGrid.Rows.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();            
            string fileName = saveFileDialog1.FileName;
            System.IO.StreamWriter file = new System.IO.StreamWriter(@fileName);

            for (int i = 0; i < ActionListGrid.Rows.Count; i++)
            {
                file.WriteLine(ActionListGrid[0, i].Value + "=" + ActionListGrid[1, i].Value);
            }
            file.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActionListGrid.Rows.Clear();
            openFileDialog1.ShowDialog();
            string fileName = openFileDialog1.FileName;
            if (fileName != "openFileDialog1")
            {
                try
                {
                    System.IO.StreamReader file = new System.IO.StreamReader(@fileName);
                    while (!file.EndOfStream)
                    {
                        string data = file.ReadLine();
                        ActionListGrid.Rows.Add();
                        ActionListGrid[0, ActionListGrid.Rows.Count - 1].Value = data.Split('=')[0];
                        ActionListGrid[1, ActionListGrid.Rows.Count - 1].Value = data.Split('=')[1];
                    }
                    file.Close();
                }
                catch { }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            botThread.Abort();
            Application.Exit();
        }

        private void CheckCursorButton_Click(object sender, EventArgs e)
        {
            string command = ActionListGrid[0, ActionListGrid.SelectedRows[0].Index].Value.ToString();
            Command action;
            CommandParser parser = new CommandParser();
            if (command!="{" && command!="}" && command.Split('(')[0] != "Repeat")
            {
                action = parser.Parse(command);
                if (!(action is Waiter))
                {
                    int x = action.firstValue;
                    int y = action.secondValue;
                    action = new MousePointer();
                    action.firstValue = x;
                    action.secondValue = y;
                    action.PerformAction();
                }
            }
        }

        private void RemoveActionButton_Click(object sender, EventArgs e)
        {
            ActionListGrid.Rows.Remove(ActionListGrid.SelectedRows[0]);

            if (ActionListGrid.Rows.Count == 0)
            {
                CheckCursorButton.Enabled = false;
                RemoveActionButton.Enabled = false;
            }
        }
    }
}