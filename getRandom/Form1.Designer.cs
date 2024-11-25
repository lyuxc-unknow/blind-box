namespace getRandom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            finalListBox = new ListBox();
            col = new TextBox();
            countInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            ingoreListBox = new ListBox();
            ingoreInputTextBox = new TextBox();
            button3 = new Button();
            toolTip1 = new ToolTip(components);
            ingoreList2Input = new TextBox();
            label3 = new Label();
            ingoreList2 = new ListBox();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 446);
            button1.Name = "button1";
            button1.Size = new Size(280, 34);
            button1.TabIndex = 1;
            button1.Text = "选择文件并抽取";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // finalListBox
            // 
            finalListBox.FormattingEnabled = true;
            finalListBox.ItemHeight = 24;
            finalListBox.Location = new Point(624, 18);
            finalListBox.Name = "finalListBox";
            finalListBox.Size = new Size(232, 508);
            finalListBox.TabIndex = 2;
            // 
            // col
            // 
            col.Location = new Point(12, 46);
            col.Name = "col";
            col.PlaceholderText = "输入列名。例如：姓名、学号.....";
            col.Size = new Size(280, 30);
            col.TabIndex = 3;
            // 
            // countInput
            // 
            countInput.Location = new Point(12, 111);
            countInput.Name = "countInput";
            countInput.Size = new Size(280, 30);
            countInput.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 18);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 5;
            label1.Text = "抽取列";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 84);
            label2.Name = "label2";
            label2.Size = new Size(82, 24);
            label2.TabIndex = 6;
            label2.Text = "抽取数量";
            // 
            // button2
            // 
            button2.Location = new Point(12, 486);
            button2.Name = "button2";
            button2.Size = new Size(280, 34);
            button2.TabIndex = 7;
            button2.Text = "清空";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ingoreListBox
            // 
            ingoreListBox.FormattingEnabled = true;
            ingoreListBox.ItemHeight = 24;
            ingoreListBox.Location = new Point(12, 285);
            ingoreListBox.Name = "ingoreListBox";
            ingoreListBox.Size = new Size(272, 148);
            ingoreListBox.TabIndex = 8;
            // 
            // ingoreInputTextBox
            // 
            ingoreInputTextBox.Location = new Point(12, 247);
            ingoreInputTextBox.Name = "ingoreInputTextBox";
            ingoreInputTextBox.Size = new Size(177, 30);
            ingoreInputTextBox.TabIndex = 9;
            toolTip1.SetToolTip(ingoreInputTextBox, "输入或者移除需要忽略的数据。\r\n如果列表中已存在则将其从列表中移除，否则添加到列表中");
            // 
            // button3
            // 
            button3.Location = new Point(201, 247);
            button3.Name = "button3";
            button3.Size = new Size(87, 32);
            button3.TabIndex = 10;
            button3.Text = "增/删";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ingoreList2Input
            // 
            ingoreList2Input.Location = new Point(12, 173);
            ingoreList2Input.Name = "ingoreList2Input";
            ingoreList2Input.Size = new Size(177, 30);
            ingoreList2Input.TabIndex = 16;
            toolTip1.SetToolTip(ingoreList2Input, "输入或者移除需要忽略的数据。\r\n如果列表中已存在则将其从列表中移除，否则添加到列表中");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 220);
            label3.Name = "label3";
            label3.Size = new Size(82, 24);
            label3.TabIndex = 11;
            label3.Text = "忽略数据";
            // 
            // ingoreList2
            // 
            ingoreList2.FormattingEnabled = true;
            ingoreList2.ItemHeight = 24;
            ingoreList2.Location = new Point(298, 18);
            ingoreList2.Name = "ingoreList2";
            ingoreList2.Size = new Size(232, 508);
            ingoreList2.TabIndex = 12;
            // 
            // button4
            // 
            button4.Location = new Point(539, 167);
            button4.Name = "button4";
            button4.Size = new Size(78, 36);
            button4.TabIndex = 13;
            button4.Text = "->";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(539, 214);
            button5.Name = "button5";
            button5.Size = new Size(78, 36);
            button5.TabIndex = 14;
            button5.Text = "<-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 144);
            label4.Name = "label4";
            label4.Size = new Size(279, 24);
            label4.TabIndex = 15;
            label4.Text = "替换数据----------------------->";
            // 
            // button6
            // 
            button6.Location = new Point(201, 173);
            button6.Name = "button6";
            button6.Size = new Size(87, 32);
            button6.TabIndex = 17;
            button6.Text = "增/删";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 538);
            Controls.Add(button6);
            Controls.Add(ingoreList2Input);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(ingoreList2);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(ingoreInputTextBox);
            Controls.Add(ingoreListBox);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(countInput);
            Controls.Add(col);
            Controls.Add(finalListBox);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "随机抽取几位幸运儿";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private ListBox finalListBox;
        private TextBox col;
        private TextBox countInput;
        private Label label1;
        private Label label2;
        private Button button2;
        private ListBox ingoreListBox;
        private TextBox ingoreInputTextBox;
        private Button button3;
        private ToolTip toolTip1;
        private Label label3;
        private ListBox ingoreList2;
        private Button button4;
        private Button button5;
        private Label label4;
        private TextBox ingoreList2Input;
        private Button button6;
    }
}
