
namespace Assignment1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeScreenImage = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.informationDisplay = new System.Windows.Forms.GroupBox();
            this.summaryTable = new System.Windows.Forms.TableLayoutPanel();
            this.avgTransValueDisplay = new System.Windows.Forms.Label();
            this.totalReceiptsDisplay = new System.Windows.Forms.Label();
            this.totalTicketsSoldDisplay = new System.Windows.Forms.Label();
            this.totalCashiersLabel = new System.Windows.Forms.Label();
            this.totalTicketsSoldLabel = new System.Windows.Forms.Label();
            this.totalReceiptsLabel = new System.Windows.Forms.Label();
            this.avgTransValueLabel = new System.Windows.Forms.Label();
            this.cashierNameDisplay = new System.Windows.Forms.Label();
            this.optionButtonContainer = new System.Windows.Forms.TableLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.ticketsCountSection = new System.Windows.Forms.GroupBox();
            this.childCountInput = new System.Windows.Forms.TextBox();
            this.studentCountInput = new System.Windows.Forms.TextBox();
            this.adultCountInput = new System.Windows.Forms.TextBox();
            this.childCountLabel = new System.Windows.Forms.Label();
            this.studentCountLabel = new System.Windows.Forms.Label();
            this.adultCountLabel = new System.Windows.Forms.Label();
            this.cashierNameInput = new System.Windows.Forms.TextBox();
            this.cashierNameLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.homeScreenImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.informationDisplay.SuspendLayout();
            this.summaryTable.SuspendLayout();
            this.optionButtonContainer.SuspendLayout();
            this.ticketsCountSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // homeScreenImage
            // 
            this.homeScreenImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.homeScreenImage.Image = ((System.Drawing.Image)(resources.GetObject("homeScreenImage.Image")));
            this.homeScreenImage.Location = new System.Drawing.Point(71, 0);
            this.homeScreenImage.Name = "homeScreenImage";
            this.homeScreenImage.Size = new System.Drawing.Size(801, 266);
            this.homeScreenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeScreenImage.TabIndex = 0;
            this.homeScreenImage.TabStop = false;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enterButton.BackColor = System.Drawing.Color.Indigo;
            this.enterButton.ForeColor = System.Drawing.Color.White;
            this.enterButton.Location = new System.Drawing.Point(380, 501);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(186, 75);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "&Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeScreenImage);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 1237);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.informationDisplay);
            this.panel2.Controls.Add(this.optionButtonContainer);
            this.panel2.Controls.Add(this.ticketsCountSection);
            this.panel2.Controls.Add(this.cashierNameInput);
            this.panel2.Controls.Add(this.cashierNameLabel);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 1237);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 1037);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(792, 172);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // informationDisplay
            // 
            this.informationDisplay.Controls.Add(this.summaryTable);
            this.informationDisplay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.informationDisplay.Location = new System.Drawing.Point(76, 555);
            this.informationDisplay.Name = "informationDisplay";
            this.informationDisplay.Size = new System.Drawing.Size(788, 348);
            this.informationDisplay.TabIndex = 4;
            this.informationDisplay.TabStop = false;
            this.informationDisplay.Text = "Cashier Summary Data";
            this.informationDisplay.Visible = false;
            // 
            // summaryTable
            // 
            this.summaryTable.ColumnCount = 2;
            this.summaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.summaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.summaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.summaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.summaryTable.Controls.Add(this.avgTransValueDisplay, 1, 3);
            this.summaryTable.Controls.Add(this.totalReceiptsDisplay, 1, 2);
            this.summaryTable.Controls.Add(this.totalTicketsSoldDisplay, 1, 1);
            this.summaryTable.Controls.Add(this.totalCashiersLabel, 0, 0);
            this.summaryTable.Controls.Add(this.totalTicketsSoldLabel, 0, 1);
            this.summaryTable.Controls.Add(this.totalReceiptsLabel, 0, 2);
            this.summaryTable.Controls.Add(this.avgTransValueLabel, 0, 3);
            this.summaryTable.Controls.Add(this.cashierNameDisplay, 1, 0);
            this.summaryTable.Location = new System.Drawing.Point(34, 62);
            this.summaryTable.Name = "summaryTable";
            this.summaryTable.RowCount = 4;
            this.summaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryTable.Size = new System.Drawing.Size(717, 250);
            this.summaryTable.TabIndex = 0;
            // 
            // avgTransValueDisplay
            // 
            this.avgTransValueDisplay.AutoSize = true;
            this.avgTransValueDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avgTransValueDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avgTransValueDisplay.Location = new System.Drawing.Point(366, 194);
            this.avgTransValueDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.avgTransValueDisplay.Name = "avgTransValueDisplay";
            this.avgTransValueDisplay.Size = new System.Drawing.Size(343, 48);
            this.avgTransValueDisplay.TabIndex = 7;
            this.avgTransValueDisplay.Text = "label4";
            this.avgTransValueDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.avgTransValueDisplay.Visible = false;
            // 
            // totalReceiptsDisplay
            // 
            this.totalReceiptsDisplay.AutoSize = true;
            this.totalReceiptsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalReceiptsDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalReceiptsDisplay.Location = new System.Drawing.Point(366, 132);
            this.totalReceiptsDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.totalReceiptsDisplay.Name = "totalReceiptsDisplay";
            this.totalReceiptsDisplay.Size = new System.Drawing.Size(343, 46);
            this.totalReceiptsDisplay.TabIndex = 6;
            this.totalReceiptsDisplay.Text = "label3";
            this.totalReceiptsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalTicketsSoldDisplay
            // 
            this.totalTicketsSoldDisplay.AutoSize = true;
            this.totalTicketsSoldDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTicketsSoldDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalTicketsSoldDisplay.Location = new System.Drawing.Point(366, 70);
            this.totalTicketsSoldDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.totalTicketsSoldDisplay.Name = "totalTicketsSoldDisplay";
            this.totalTicketsSoldDisplay.Size = new System.Drawing.Size(343, 46);
            this.totalTicketsSoldDisplay.TabIndex = 5;
            this.totalTicketsSoldDisplay.Text = "label2";
            this.totalTicketsSoldDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalCashiersLabel
            // 
            this.totalCashiersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalCashiersLabel.AutoSize = true;
            this.totalCashiersLabel.Location = new System.Drawing.Point(3, 0);
            this.totalCashiersLabel.Name = "totalCashiersLabel";
            this.totalCashiersLabel.Size = new System.Drawing.Size(352, 62);
            this.totalCashiersLabel.TabIndex = 0;
            this.totalCashiersLabel.Text = "Cashier Name";
            this.totalCashiersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalTicketsSoldLabel
            // 
            this.totalTicketsSoldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalTicketsSoldLabel.AutoSize = true;
            this.totalTicketsSoldLabel.Location = new System.Drawing.Point(3, 62);
            this.totalTicketsSoldLabel.Name = "totalTicketsSoldLabel";
            this.totalTicketsSoldLabel.Size = new System.Drawing.Size(352, 62);
            this.totalTicketsSoldLabel.TabIndex = 1;
            this.totalTicketsSoldLabel.Text = "Total Tickets Sold";
            this.totalTicketsSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalReceiptsLabel
            // 
            this.totalReceiptsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.totalReceiptsLabel.AutoSize = true;
            this.totalReceiptsLabel.Location = new System.Drawing.Point(3, 124);
            this.totalReceiptsLabel.Name = "totalReceiptsLabel";
            this.totalReceiptsLabel.Size = new System.Drawing.Size(352, 62);
            this.totalReceiptsLabel.TabIndex = 2;
            this.totalReceiptsLabel.Text = "Total Receipts";
            this.totalReceiptsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // avgTransValueLabel
            // 
            this.avgTransValueLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.avgTransValueLabel.AutoSize = true;
            this.avgTransValueLabel.Location = new System.Drawing.Point(3, 186);
            this.avgTransValueLabel.Name = "avgTransValueLabel";
            this.avgTransValueLabel.Size = new System.Drawing.Size(352, 64);
            this.avgTransValueLabel.TabIndex = 3;
            this.avgTransValueLabel.Text = "Avg Trans Value";
            this.avgTransValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.avgTransValueLabel.Visible = false;
            // 
            // cashierNameDisplay
            // 
            this.cashierNameDisplay.AutoSize = true;
            this.cashierNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierNameDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cashierNameDisplay.Location = new System.Drawing.Point(366, 8);
            this.cashierNameDisplay.Margin = new System.Windows.Forms.Padding(8);
            this.cashierNameDisplay.Name = "cashierNameDisplay";
            this.cashierNameDisplay.Size = new System.Drawing.Size(343, 46);
            this.cashierNameDisplay.TabIndex = 4;
            this.cashierNameDisplay.Text = "label1";
            this.cashierNameDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // optionButtonContainer
            // 
            this.optionButtonContainer.ColumnCount = 4;
            this.optionButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.optionButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.optionButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.optionButtonContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.optionButtonContainer.Controls.Add(this.exitButton, 3, 0);
            this.optionButtonContainer.Controls.Add(this.summaryButton, 2, 0);
            this.optionButtonContainer.Controls.Add(this.clearButton, 1, 0);
            this.optionButtonContainer.Controls.Add(this.calculateButton, 0, 0);
            this.optionButtonContainer.Location = new System.Drawing.Point(76, 413);
            this.optionButtonContainer.Name = "optionButtonContainer";
            this.optionButtonContainer.Padding = new System.Windows.Forms.Padding(10);
            this.optionButtonContainer.RowCount = 1;
            this.optionButtonContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionButtonContainer.Size = new System.Drawing.Size(788, 106);
            this.optionButtonContainer.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.Indigo;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(594, 18);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(176, 70);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            this.exitButton.MouseHover += new System.EventHandler(this.exitButton_MouseHover);
            // 
            // summaryButton
            // 
            this.summaryButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryButton.BackColor = System.Drawing.Color.Indigo;
            this.summaryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.summaryButton.ForeColor = System.Drawing.Color.White;
            this.summaryButton.Location = new System.Drawing.Point(402, 18);
            this.summaryButton.Margin = new System.Windows.Forms.Padding(8);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(176, 70);
            this.summaryButton.TabIndex = 4;
            this.summaryButton.UseVisualStyleBackColor = false;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            this.summaryButton.MouseHover += new System.EventHandler(this.summaryButton_MouseHover);
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.BackColor = System.Drawing.Color.Indigo;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(210, 18);
            this.clearButton.Margin = new System.Windows.Forms.Padding(8);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(176, 70);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            this.clearButton.MouseHover += new System.EventHandler(this.clearButton_MouseHover);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.BackColor = System.Drawing.Color.Indigo;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(18, 18);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(8);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(176, 70);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "C&alculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            this.calculateButton.MouseHover += new System.EventHandler(this.calculateButton_MouseHover);
            // 
            // ticketsCountSection
            // 
            this.ticketsCountSection.AutoSize = true;
            this.ticketsCountSection.Controls.Add(this.childCountInput);
            this.ticketsCountSection.Controls.Add(this.studentCountInput);
            this.ticketsCountSection.Controls.Add(this.adultCountInput);
            this.ticketsCountSection.Controls.Add(this.childCountLabel);
            this.ticketsCountSection.Controls.Add(this.studentCountLabel);
            this.ticketsCountSection.Controls.Add(this.adultCountLabel);
            this.ticketsCountSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ticketsCountSection.Location = new System.Drawing.Point(76, 131);
            this.ticketsCountSection.Name = "ticketsCountSection";
            this.ticketsCountSection.Size = new System.Drawing.Size(788, 252);
            this.ticketsCountSection.TabIndex = 2;
            this.ticketsCountSection.TabStop = false;
            this.ticketsCountSection.Text = "Tickets";
            // 
            // childCountInput
            // 
            this.childCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.childCountInput.Location = new System.Drawing.Point(528, 173);
            this.childCountInput.Name = "childCountInput";
            this.childCountInput.Size = new System.Drawing.Size(120, 39);
            this.childCountInput.TabIndex = 5;
            this.childCountInput.Text = "0";
            this.childCountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // studentCountInput
            // 
            this.studentCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentCountInput.Location = new System.Drawing.Point(528, 119);
            this.studentCountInput.Name = "studentCountInput";
            this.studentCountInput.Size = new System.Drawing.Size(120, 39);
            this.studentCountInput.TabIndex = 4;
            this.studentCountInput.Text = "0";
            this.studentCountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adultCountInput
            // 
            this.adultCountInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adultCountInput.Location = new System.Drawing.Point(528, 65);
            this.adultCountInput.Name = "adultCountInput";
            this.adultCountInput.Size = new System.Drawing.Size(120, 39);
            this.adultCountInput.TabIndex = 3;
            this.adultCountInput.Text = "0";
            this.adultCountInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // childCountLabel
            // 
            this.childCountLabel.AutoSize = true;
            this.childCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.childCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.childCountLabel.Location = new System.Drawing.Point(184, 175);
            this.childCountLabel.Name = "childCountLabel";
            this.childCountLabel.Size = new System.Drawing.Size(72, 32);
            this.childCountLabel.TabIndex = 2;
            this.childCountLabel.Text = "Child";
            // 
            // studentCountLabel
            // 
            this.studentCountLabel.AutoSize = true;
            this.studentCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.studentCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.studentCountLabel.Location = new System.Drawing.Point(159, 121);
            this.studentCountLabel.Name = "studentCountLabel";
            this.studentCountLabel.Size = new System.Drawing.Size(102, 32);
            this.studentCountLabel.TabIndex = 1;
            this.studentCountLabel.Text = "Student";
            // 
            // adultCountLabel
            // 
            this.adultCountLabel.AutoSize = true;
            this.adultCountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adultCountLabel.Location = new System.Drawing.Point(184, 67);
            this.adultCountLabel.Name = "adultCountLabel";
            this.adultCountLabel.Size = new System.Drawing.Size(77, 32);
            this.adultCountLabel.TabIndex = 0;
            this.adultCountLabel.Text = "Adult";
            this.adultCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cashierNameInput
            // 
            this.cashierNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cashierNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cashierNameInput.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cashierNameInput.Location = new System.Drawing.Point(525, 64);
            this.cashierNameInput.Name = "cashierNameInput";
            this.cashierNameInput.Size = new System.Drawing.Size(302, 39);
            this.cashierNameInput.TabIndex = 1;
            this.cashierNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cashierNameLabel
            // 
            this.cashierNameLabel.AutoSize = true;
            this.cashierNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cashierNameLabel.Location = new System.Drawing.Point(67, 64);
            this.cashierNameLabel.Name = "cashierNameLabel";
            this.cashierNameLabel.Size = new System.Drawing.Size(171, 96);
            this.cashierNameLabel.TabIndex = 0;
            this.cashierNameLabel.Text = "Cashier Name\r\n\r\n\r\n";
            // 
            // toolTip
            // 
            this.toolTip.IsBalloon = true;
            this.toolTip.Tag = "Press to exit application";
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 1238);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Mega Cinema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeScreenImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.informationDisplay.ResumeLayout(false);
            this.summaryTable.ResumeLayout(false);
            this.summaryTable.PerformLayout();
            this.optionButtonContainer.ResumeLayout(false);
            this.ticketsCountSection.ResumeLayout(false);
            this.ticketsCountSection.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox homeScreenImage;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox ticketsCountSection;
        private System.Windows.Forms.Label childCountLabel;
        private System.Windows.Forms.Label studentCountLabel;
        private System.Windows.Forms.Label adultCountLabel;
        private System.Windows.Forms.TextBox cashierNameInput;
        private System.Windows.Forms.Label cashierNameLabel;
        private System.Windows.Forms.TextBox adultCountInput;
        private System.Windows.Forms.TextBox childCountInput;
        private System.Windows.Forms.TextBox studentCountInput;
        private System.Windows.Forms.TableLayoutPanel optionButtonContainer;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.GroupBox companySummaryBox;
        private System.Windows.Forms.TableLayoutPanel summaryTable;
        private System.Windows.Forms.Label totalCashiersLabel;
        private System.Windows.Forms.Label totalTicketsSoldLabel;
        private System.Windows.Forms.Label totalReceiptsLabel;
        private System.Windows.Forms.Label AvgTransValueLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalReceiptsDisplay;
        private System.Windows.Forms.Label totalTicketsSoldDisplay;
        private System.Windows.Forms.GroupBox informationDisplay;
        private System.Windows.Forms.Label avgTransValueDisplay;
        private System.Windows.Forms.Label avgTransValueLabel;
        private System.Windows.Forms.Label cashierNameDisplay;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

