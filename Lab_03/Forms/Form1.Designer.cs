
namespace Lab_3_Mech
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.рисунокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нарисоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стеретьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.остановитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.геометрическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кинематическиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.траекторияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкаАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.точкаВToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Lr2 = new System.Windows.Forms.Label();
            this.Lr1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LOmega = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рисунокToolStripMenuItem,
            this.движениеToolStripMenuItem,
            this.параметрыToolStripMenuItem,
            this.траекторияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // рисунокToolStripMenuItem
            // 
            this.рисунокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.нарисоватьToolStripMenuItem,
            this.стеретьToolStripMenuItem});
            this.рисунокToolStripMenuItem.Name = "рисунокToolStripMenuItem";
            this.рисунокToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.рисунокToolStripMenuItem.Text = "Drawing";
            // 
            // нарисоватьToolStripMenuItem
            // 
            this.нарисоватьToolStripMenuItem.Name = "нарисоватьToolStripMenuItem";
            this.нарисоватьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this.нарисоватьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.нарисоватьToolStripMenuItem.Text = "Draw";
            this.нарисоватьToolStripMenuItem.Click += new System.EventHandler(this.нарисоватьToolStripMenuItem_Click);
            // 
            // стеретьToolStripMenuItem
            // 
            this.стеретьToolStripMenuItem.Enabled = false;
            this.стеретьToolStripMenuItem.Name = "стеретьToolStripMenuItem";
            this.стеретьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.стеретьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.стеретьToolStripMenuItem.Text = "Erase";
            this.стеретьToolStripMenuItem.Click += new System.EventHandler(this.стеретьToolStripMenuItem_Click);
            // 
            // движениеToolStripMenuItem
            // 
            this.движениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьToolStripMenuItem,
            this.остановитьToolStripMenuItem});
            this.движениеToolStripMenuItem.Name = "движениеToolStripMenuItem";
            this.движениеToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.движениеToolStripMenuItem.Text = "Movement";
            // 
            // начатьToolStripMenuItem
            // 
            this.начатьToolStripMenuItem.Enabled = false;
            this.начатьToolStripMenuItem.Name = "начатьToolStripMenuItem";
            this.начатьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.начатьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.начатьToolStripMenuItem.Text = "Start";
            this.начатьToolStripMenuItem.Click += new System.EventHandler(this.начатьToolStripMenuItem_Click);
            // 
            // остановитьToolStripMenuItem
            // 
            this.остановитьToolStripMenuItem.Enabled = false;
            this.остановитьToolStripMenuItem.Name = "остановитьToolStripMenuItem";
            this.остановитьToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.остановитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.остановитьToolStripMenuItem.Text = "Stop";
            this.остановитьToolStripMenuItem.Click += new System.EventHandler(this.остановитьToolStripMenuItem_Click);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.геометрическиеToolStripMenuItem,
            this.кинематическиеToolStripMenuItem});
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.параметрыToolStripMenuItem.Text = "Parameters";
            // 
            // геометрическиеToolStripMenuItem
            // 
            this.геометрическиеToolStripMenuItem.Name = "геометрическиеToolStripMenuItem";
            this.геометрическиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.геометрическиеToolStripMenuItem.Text = "Geometric";
            this.геометрическиеToolStripMenuItem.Click += new System.EventHandler(this.геометрическиеToolStripMenuItem_Click);
            // 
            // кинематическиеToolStripMenuItem
            // 
            this.кинематическиеToolStripMenuItem.Name = "кинематическиеToolStripMenuItem";
            this.кинематическиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.кинематическиеToolStripMenuItem.Text = "Kinematic ";
            this.кинематическиеToolStripMenuItem.Click += new System.EventHandler(this.кинематическиеToolStripMenuItem_Click);
            // 
            // траекторияToolStripMenuItem
            // 
            this.траекторияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.точкаАToolStripMenuItem,
            this.точкаВToolStripMenuItem});
            this.траекторияToolStripMenuItem.Name = "траекторияToolStripMenuItem";
            this.траекторияToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.траекторияToolStripMenuItem.Text = "Trajectory";
            // 
            // точкаАToolStripMenuItem
            // 
            this.точкаАToolStripMenuItem.Name = "точкаАToolStripMenuItem";
            this.точкаАToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.точкаАToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точкаАToolStripMenuItem.Text = "Point A";
            this.точкаАToolStripMenuItem.Click += new System.EventHandler(this.точкаАToolStripMenuItem_Click);
            // 
            // точкаВToolStripMenuItem
            // 
            this.точкаВToolStripMenuItem.Name = "точкаВToolStripMenuItem";
            this.точкаВToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.точкаВToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.точкаВToolStripMenuItem.Text = "Point B";
            this.точкаВToolStripMenuItem.Click += new System.EventHandler(this.точкаВToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Lr2);
            this.panel1.Controls.Add(this.Lr1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.LOmega);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 903);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(857, 89);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Angular speed of the big wheel:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(353, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 31);
            this.label10.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Point В:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(117, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 31);
            this.label6.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Point A:";
            // 
            // Lr2
            // 
            this.Lr2.AutoSize = true;
            this.Lr2.Location = new System.Drawing.Point(555, 17);
            this.Lr2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lr2.Name = "Lr2";
            this.Lr2.Size = new System.Drawing.Size(0, 16);
            this.Lr2.TabIndex = 6;
            // 
            // Lr1
            // 
            this.Lr1.AutoSize = true;
            this.Lr1.Location = new System.Drawing.Point(377, 17);
            this.Lr1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lr1.Name = "Lr1";
            this.Lr1.Size = new System.Drawing.Size(0, 16);
            this.Lr1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Radius R1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Radius r1:";
            // 
            // LOmega
            // 
            this.LOmega.AutoSize = true;
            this.LOmega.Location = new System.Drawing.Point(173, 17);
            this.LOmega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LOmega.Name = "LOmega";
            this.LOmega.Size = new System.Drawing.Size(0, 16);
            this.LOmega.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angular speed of the crank:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(161, 146);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 249);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 992);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kinematics of the mechanism";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem рисунокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нарисоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стеретьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem геометрическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кинематическиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem траекторияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкаАToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem точкаВToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lr2;
        private System.Windows.Forms.Label Lr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LOmega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

