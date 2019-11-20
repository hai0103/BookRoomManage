namespace BookRoomGUI
{
    partial class frmUcBookRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DateTimePicker dtStartDate;
            this.flpRooms = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddBookRoom = new System.Windows.Forms.Button();
            dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // flpRooms
            // 
            this.flpRooms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpRooms.Location = new System.Drawing.Point(0, 90);
            this.flpRooms.Margin = new System.Windows.Forms.Padding(8);
            this.flpRooms.Name = "flpRooms";
            this.flpRooms.Size = new System.Drawing.Size(881, 431);
            this.flpRooms.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(515, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 26);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dtStartDate
            // 
            dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dtStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtStartDate.Location = new System.Drawing.Point(355, 28);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new System.Drawing.Size(125, 26);
            dtStartDate.TabIndex = 11;
            dtStartDate.UseWaitCursor = true;
            dtStartDate.Value = new System.DateTime(2019, 11, 17, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 28);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Type Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "to";
            // 
            // btnAddBookRoom
            // 
            this.btnAddBookRoom.BackColor = System.Drawing.Color.White;
            this.btnAddBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBookRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBookRoom.Location = new System.Drawing.Point(684, 25);
            this.btnAddBookRoom.Name = "btnAddBookRoom";
            this.btnAddBookRoom.Size = new System.Drawing.Size(121, 32);
            this.btnAddBookRoom.TabIndex = 19;
            this.btnAddBookRoom.Text = "Filter";
            this.btnAddBookRoom.UseVisualStyleBackColor = false;
            // 
            // frmUcBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnAddBookRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(dtStartDate);
            this.Controls.Add(this.flpRooms);
            this.Name = "frmUcBookRoom";
            this.Size = new System.Drawing.Size(881, 521);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel flpRooms;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddBookRoom;
    }
}
