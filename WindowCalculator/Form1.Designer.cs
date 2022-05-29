namespace WindowCalculator
{
    partial class SmartCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SmartCalculator));
            this.btnEquals_Click = new System.Windows.Forms.Button();
            this.btndote = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button35 = new System.Windows.Forms.Button();
            this.plus_click = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.three_click = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.minus_click = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.six_click = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.mutiply_click = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.nine_click = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.eight_click = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.seven_click = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.divide_click = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.backspace = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblshowOp = new System.Windows.Forms.Label();
            this.btnHistory = new System.Windows.Forms.Label();
            this.btnMemory = new System.Windows.Forms.Label();
            this.lblHISTORY = new System.Windows.Forms.Label();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.Undobtn = new System.Windows.Forms.Button();
            this.Redobtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEquals_Click
            // 
            this.btnEquals_Click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals_Click.Location = new System.Drawing.Point(266, 612);
            this.btnEquals_Click.Name = "btnEquals_Click";
            this.btnEquals_Click.Size = new System.Drawing.Size(78, 47);
            this.btnEquals_Click.TabIndex = 127;
            this.btnEquals_Click.Text = "=";
            this.btnEquals_Click.UseVisualStyleBackColor = true;
            this.btnEquals_Click.Click += new System.EventHandler(this.btnEquals_Click_Click);
            // 
            // btndote
            // 
            this.btndote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndote.Location = new System.Drawing.Point(182, 612);
            this.btndote.Name = "btndote";
            this.btndote.Size = new System.Drawing.Size(78, 47);
            this.btndote.TabIndex = 126;
            this.btndote.Text = ".";
            this.btndote.UseVisualStyleBackColor = true;
            this.btndote.Click += new System.EventHandler(this.Numbers);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(98, 612);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(78, 47);
            this.btn0.TabIndex = 125;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numbers);
            // 
            // button35
            // 
            this.button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button35.Location = new System.Drawing.Point(14, 612);
            this.button35.Name = "button35";
            this.button35.Size = new System.Drawing.Size(78, 47);
            this.button35.TabIndex = 124;
            this.button35.Text = "+/-";
            this.button35.UseVisualStyleBackColor = true;
            // 
            // plus_click
            // 
            this.plus_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_click.Location = new System.Drawing.Point(266, 553);
            this.plus_click.Name = "plus_click";
            this.plus_click.Size = new System.Drawing.Size(78, 47);
            this.plus_click.TabIndex = 123;
            this.plus_click.Text = "+";
            this.plus_click.UseVisualStyleBackColor = true;
            this.plus_click.Click += new System.EventHandler(this.operators_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(182, 556);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(78, 47);
            this.btn3.TabIndex = 122;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numbers);
            // 
            // three_click
            // 
            this.three_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three_click.Location = new System.Drawing.Point(182, 553);
            this.three_click.Name = "three_click";
            this.three_click.Size = new System.Drawing.Size(78, 47);
            this.three_click.TabIndex = 121;
            this.three_click.Text = "3";
            this.three_click.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(98, 553);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(78, 47);
            this.btn2.TabIndex = 120;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(14, 553);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(78, 47);
            this.btn1.TabIndex = 119;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numbers);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(64, 606);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(8, 8);
            this.button31.TabIndex = 118;
            this.button31.Text = "button31";
            this.button31.UseVisualStyleBackColor = true;
            // 
            // minus_click
            // 
            this.minus_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minus_click.Location = new System.Drawing.Point(266, 500);
            this.minus_click.Name = "minus_click";
            this.minus_click.Size = new System.Drawing.Size(78, 47);
            this.minus_click.TabIndex = 117;
            this.minus_click.Text = "-";
            this.minus_click.UseVisualStyleBackColor = true;
            this.minus_click.Click += new System.EventHandler(this.operators_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(182, 503);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(78, 47);
            this.btn6.TabIndex = 116;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numbers);
            // 
            // six_click
            // 
            this.six_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six_click.Location = new System.Drawing.Point(182, 500);
            this.six_click.Name = "six_click";
            this.six_click.Size = new System.Drawing.Size(78, 47);
            this.six_click.TabIndex = 115;
            this.six_click.Text = "6";
            this.six_click.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(98, 500);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(78, 47);
            this.btn5.TabIndex = 114;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(14, 500);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(78, 47);
            this.btn4.TabIndex = 113;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numbers);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(64, 553);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(8, 8);
            this.button26.TabIndex = 112;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // mutiply_click
            // 
            this.mutiply_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mutiply_click.Location = new System.Drawing.Point(266, 447);
            this.mutiply_click.Name = "mutiply_click";
            this.mutiply_click.Size = new System.Drawing.Size(78, 47);
            this.mutiply_click.TabIndex = 111;
            this.mutiply_click.Text = "x";
            this.mutiply_click.UseVisualStyleBackColor = true;
            this.mutiply_click.Click += new System.EventHandler(this.operators_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(182, 450);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(78, 47);
            this.btn9.TabIndex = 110;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numbers);
            // 
            // nine_click
            // 
            this.nine_click.Location = new System.Drawing.Point(182, 447);
            this.nine_click.Name = "nine_click";
            this.nine_click.Size = new System.Drawing.Size(78, 47);
            this.nine_click.TabIndex = 109;
            this.nine_click.Text = "9";
            this.nine_click.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(98, 450);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(78, 47);
            this.btn8.TabIndex = 108;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numbers);
            // 
            // eight_click
            // 
            this.eight_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eight_click.Location = new System.Drawing.Point(98, 447);
            this.eight_click.Name = "eight_click";
            this.eight_click.Size = new System.Drawing.Size(78, 47);
            this.eight_click.TabIndex = 107;
            this.eight_click.Text = "8";
            this.eight_click.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(14, 450);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(78, 47);
            this.btn7.TabIndex = 106;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numbers);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(14, 450);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(78, 47);
            this.button12.TabIndex = 105;
            this.button12.Text = "7";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // seven_click
            // 
            this.seven_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven_click.Location = new System.Drawing.Point(14, 447);
            this.seven_click.Name = "seven_click";
            this.seven_click.Size = new System.Drawing.Size(78, 47);
            this.seven_click.TabIndex = 104;
            this.seven_click.Text = "7";
            this.seven_click.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(64, 500);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(8, 8);
            this.button21.TabIndex = 103;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // divide_click
            // 
            this.divide_click.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divide_click.Location = new System.Drawing.Point(266, 394);
            this.divide_click.Name = "divide_click";
            this.divide_click.Size = new System.Drawing.Size(78, 47);
            this.divide_click.TabIndex = 102;
            this.divide_click.Text = "÷";
            this.divide_click.UseVisualStyleBackColor = true;
            this.divide_click.Click += new System.EventHandler(this.operators_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(182, 394);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(78, 47);
            this.button13.TabIndex = 101;
            this.button13.Text = "2√x";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(98, 394);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(78, 47);
            this.button14.TabIndex = 100;
            this.button14.Text = "x²";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(14, 394);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(78, 47);
            this.button15.TabIndex = 99;
            this.button15.Text = "1/X";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(64, 447);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(8, 8);
            this.button16.TabIndex = 98;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // backspace
            // 
            this.backspace.Font = new System.Drawing.Font("Wingdings", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.backspace.Location = new System.Drawing.Point(266, 341);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(78, 47);
            this.backspace.TabIndex = 97;
            this.backspace.Text = "";
            this.backspace.UseVisualStyleBackColor = true;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(182, 341);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(78, 47);
            this.C.TabIndex = 96;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.C_Click);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(98, 341);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(78, 47);
            this.CE.TabIndex = 95;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(14, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 47);
            this.button8.TabIndex = 94;
            this.button8.Text = "%";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(64, 394);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(8, 8);
            this.button7.TabIndex = 93;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(-3, 108);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(5);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(365, 128);
            this.txtDisplay.TabIndex = 92;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(282, 298);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(62, 37);
            this.button6.TabIndex = 91;
            this.button6.Text = "M⁻";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(226, 298);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(58, 37);
            this.button5.TabIndex = 90;
            this.button5.Text = "MS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(174, 298);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 37);
            this.button4.TabIndex = 89;
            this.button4.Text = "M-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(127, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 37);
            this.button3.TabIndex = 88;
            this.button3.Text = "M+";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(79, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 37);
            this.button2.TabIndex = 87;
            this.button2.Text = "MR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 37);
            this.button1.TabIndex = 86;
            this.button1.Text = "MC";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 29);
            this.label2.TabIndex = 128;
            this.label2.Text = "☰";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 129;
            this.label1.Text = " STANDARD  ";
            // 
            // lblshowOp
            // 
            this.lblshowOp.AutoSize = true;
            this.lblshowOp.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowOp.Location = new System.Drawing.Point(300, 58);
            this.lblshowOp.Name = "lblshowOp";
            this.lblshowOp.Size = new System.Drawing.Size(0, 25);
            this.lblshowOp.TabIndex = 130;
            // 
            // btnHistory
            // 
            this.btnHistory.AutoSize = true;
            this.btnHistory.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistory.Location = new System.Drawing.Point(362, 9);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(87, 25);
            this.btnHistory.TabIndex = 131;
            this.btnHistory.Text = " History ";
            // 
            // btnMemory
            // 
            this.btnMemory.AutoSize = true;
            this.btnMemory.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.Location = new System.Drawing.Point(477, 12);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(87, 25);
            this.btnMemory.TabIndex = 132;
            this.btnMemory.Text = "Memory";
            // 
            // lblHISTORY
            // 
            this.lblHISTORY.AutoSize = true;
            this.lblHISTORY.Font = new System.Drawing.Font("Ebrima", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHISTORY.Location = new System.Drawing.Point(512, 58);
            this.lblHISTORY.Name = "lblHISTORY";
            this.lblHISTORY.Size = new System.Drawing.Size(203, 25);
            this.lblHISTORY.TabIndex = 133;
            this.lblHISTORY.Text = "There\'s no history yet";
            this.lblHISTORY.Click += new System.EventHandler(this.lblHISTORY_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rtbDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDisplay.Location = new System.Drawing.Point(496, 130);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(328, 524);
            this.rtbDisplay.TabIndex = 134;
            this.rtbDisplay.Text = "";
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearHistory.Font = new System.Drawing.Font("Wingdings 2", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnClearHistory.Location = new System.Drawing.Point(657, 660);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(75, 36);
            this.btnClearHistory.TabIndex = 135;
            this.btnClearHistory.Text = "";
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            // 
            // Undobtn
            // 
            this.Undobtn.Location = new System.Drawing.Point(53, 673);
            this.Undobtn.Name = "Undobtn";
            this.Undobtn.Size = new System.Drawing.Size(75, 23);
            this.Undobtn.TabIndex = 136;
            this.Undobtn.Text = "Undo";
            this.Undobtn.UseVisualStyleBackColor = true;
            // 
            // Redobtn
            // 
            this.Redobtn.Location = new System.Drawing.Point(185, 673);
            this.Redobtn.Name = "Redobtn";
            this.Redobtn.Size = new System.Drawing.Size(75, 23);
            this.Redobtn.TabIndex = 137;
            this.Redobtn.Text = "Redo";
            this.Redobtn.UseVisualStyleBackColor = true;
            // 
            // SmartCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 696);
            this.Controls.Add(this.Redobtn);
            this.Controls.Add(this.Undobtn);
            this.Controls.Add(this.btnClearHistory);
            this.Controls.Add(this.rtbDisplay);
            this.Controls.Add(this.lblHISTORY);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.lblshowOp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEquals_Click);
            this.Controls.Add(this.btndote);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.button35);
            this.Controls.Add(this.plus_click);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.three_click);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.minus_click);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.six_click);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.mutiply_click);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.nine_click);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.eight_click);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.seven_click);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.divide_click);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.C);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SmartCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SmartCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Numbers);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEquals_Click;
        private System.Windows.Forms.Button btndote;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button35;
        private System.Windows.Forms.Button plus_click;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button three_click;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button minus_click;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button six_click;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button mutiply_click;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button nine_click;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button eight_click;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button seven_click;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button divide_click;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblshowOp;
        private System.Windows.Forms.Label btnHistory;
        private System.Windows.Forms.Label btnMemory;
        private System.Windows.Forms.Label lblHISTORY;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Button Undobtn;
        private System.Windows.Forms.Button Redobtn;
    }
}

