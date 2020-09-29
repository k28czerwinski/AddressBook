namespace AddressBook
{
    partial class AddContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.HeaderText = new System.Windows.Forms.Label();
            this.HeaderTheme = new System.Windows.Forms.PictureBox();
            this.backGroundTheme = new System.Windows.Forms.PictureBox();
            this.askTheme = new System.Windows.Forms.PictureBox();
            this.askInput = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.CancelActionButton = new System.Windows.Forms.Button();
            this.WindowBorder = new System.Windows.Forms.PictureBox();
            this.InputValue = new System.Windows.Forms.TextBox();
            this.InputTheme = new System.Windows.Forms.PictureBox();
            this.informationTheme = new System.Windows.Forms.PictureBox();
            this.informationInput = new System.Windows.Forms.TextBox();
            this.Navigate = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.askTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationTheme)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderText
            // 
            this.HeaderText.AutoSize = true;
            this.HeaderText.BackColor = System.Drawing.Color.Silver;
            this.HeaderText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HeaderText.Location = new System.Drawing.Point(103, 26);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(319, 23);
            this.HeaderText.TabIndex = 0;
            this.HeaderText.Text = "KREATOR DODAWANIA KONTAKTU";
            // 
            // HeaderTheme
            // 
            this.HeaderTheme.BackColor = System.Drawing.Color.Silver;
            this.HeaderTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HeaderTheme.Location = new System.Drawing.Point(12, 12);
            this.HeaderTheme.Name = "HeaderTheme";
            this.HeaderTheme.Size = new System.Drawing.Size(501, 50);
            this.HeaderTheme.TabIndex = 1;
            this.HeaderTheme.TabStop = false;
            // 
            // backGroundTheme
            // 
            this.backGroundTheme.BackColor = System.Drawing.Color.White;
            this.backGroundTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backGroundTheme.Location = new System.Drawing.Point(12, 73);
            this.backGroundTheme.Name = "backGroundTheme";
            this.backGroundTheme.Size = new System.Drawing.Size(501, 192);
            this.backGroundTheme.TabIndex = 2;
            this.backGroundTheme.TabStop = false;
            // 
            // askTheme
            // 
            this.askTheme.BackColor = System.Drawing.SystemColors.Control;
            this.askTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.askTheme.Location = new System.Drawing.Point(22, 84);
            this.askTheme.Name = "askTheme";
            this.askTheme.Size = new System.Drawing.Size(480, 33);
            this.askTheme.TabIndex = 3;
            this.askTheme.TabStop = false;
            // 
            // askInput
            // 
            this.askInput.BackColor = System.Drawing.SystemColors.Control;
            this.askInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.askInput.Enabled = false;
            this.askInput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.askInput.ForeColor = System.Drawing.Color.Black;
            this.askInput.Location = new System.Drawing.Point(86, 92);
            this.askInput.Name = "askInput";
            this.askInput.Size = new System.Drawing.Size(352, 16);
            this.askInput.TabIndex = 4;
            this.askInput.Text = "informacja";
            this.askInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.askInput.WordWrap = false;
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.DarkGray;
            this.okButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.okButton.Location = new System.Drawing.Point(22, 211);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(237, 43);
            this.okButton.TabIndex = 194;
            this.okButton.TabStop = false;
            this.okButton.Text = "ZATWIERDŹ";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // CancelActionButton
            // 
            this.CancelActionButton.BackColor = System.Drawing.Color.DarkGray;
            this.CancelActionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelActionButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CancelActionButton.Location = new System.Drawing.Point(265, 211);
            this.CancelActionButton.Name = "CancelActionButton";
            this.CancelActionButton.Size = new System.Drawing.Size(237, 43);
            this.CancelActionButton.TabIndex = 195;
            this.CancelActionButton.TabStop = false;
            this.CancelActionButton.Text = "ANULUJ";
            this.CancelActionButton.UseVisualStyleBackColor = false;
            this.CancelActionButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // WindowBorder
            // 
            this.WindowBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WindowBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WindowBorder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WindowBorder.Location = new System.Drawing.Point(0, 0);
            this.WindowBorder.Name = "WindowBorder";
            this.WindowBorder.Size = new System.Drawing.Size(525, 277);
            this.WindowBorder.TabIndex = 196;
            this.WindowBorder.TabStop = false;
            this.WindowBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseDown);
            this.WindowBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseMove);
            this.WindowBorder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.WindowBorder_MouseUp);
            // 
            // InputValue
            // 
            this.InputValue.BackColor = System.Drawing.Color.White;
            this.InputValue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InputValue.ForeColor = System.Drawing.Color.Black;
            this.InputValue.Location = new System.Drawing.Point(38, 135);
            this.InputValue.Name = "InputValue";
            this.InputValue.Size = new System.Drawing.Size(448, 19);
            this.InputValue.TabIndex = 197;
            this.InputValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputValue.WordWrap = false;
            this.InputValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputValue_KeyDown);
            // 
            // InputTheme
            // 
            this.InputTheme.BackColor = System.Drawing.Color.White;
            this.InputTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputTheme.Location = new System.Drawing.Point(22, 123);
            this.InputTheme.Name = "InputTheme";
            this.InputTheme.Size = new System.Drawing.Size(480, 43);
            this.InputTheme.TabIndex = 198;
            this.InputTheme.TabStop = false;
            this.InputTheme.Click += new System.EventHandler(this.InputTheme_Click);
            // 
            // informationTheme
            // 
            this.informationTheme.BackColor = System.Drawing.SystemColors.Control;
            this.informationTheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.informationTheme.Location = new System.Drawing.Point(22, 172);
            this.informationTheme.Name = "informationTheme";
            this.informationTheme.Size = new System.Drawing.Size(480, 33);
            this.informationTheme.TabIndex = 199;
            this.informationTheme.TabStop = false;
            // 
            // informationInput
            // 
            this.informationInput.BackColor = System.Drawing.SystemColors.Control;
            this.informationInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationInput.Enabled = false;
            this.informationInput.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.informationInput.ForeColor = System.Drawing.Color.Black;
            this.informationInput.Location = new System.Drawing.Point(62, 180);
            this.informationInput.Name = "informationInput";
            this.informationInput.Size = new System.Drawing.Size(400, 16);
            this.informationInput.TabIndex = 200;
            this.informationInput.Text = "informacja";
            this.informationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(525, 277);
            this.Controls.Add(this.informationInput);
            this.Controls.Add(this.informationTheme);
            this.Controls.Add(this.InputValue);
            this.Controls.Add(this.InputTheme);
            this.Controls.Add(this.CancelActionButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.askInput);
            this.Controls.Add(this.askTheme);
            this.Controls.Add(this.backGroundTheme);
            this.Controls.Add(this.HeaderText);
            this.Controls.Add(this.HeaderTheme);
            this.Controls.Add(this.WindowBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddContact";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie Kontaktu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddContact_FormClosing);
            this.Load += new System.EventHandler(this.AddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HeaderTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backGroundTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.askTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindowBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InputTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationTheme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderText;
        private System.Windows.Forms.PictureBox HeaderTheme;
        private System.Windows.Forms.PictureBox backGroundTheme;
        private System.Windows.Forms.PictureBox askTheme;
        private System.Windows.Forms.TextBox askInput;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button CancelActionButton;
        private System.Windows.Forms.PictureBox WindowBorder;
        private System.Windows.Forms.TextBox InputValue;
        private System.Windows.Forms.PictureBox InputTheme;
        private System.Windows.Forms.PictureBox informationTheme;
        private System.Windows.Forms.TextBox informationInput;
        private System.Windows.Forms.ToolTip Navigate;
    }
}