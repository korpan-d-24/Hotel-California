
namespace Kursach_2._0
{
    partial class Admin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReservation = new System.Windows.Forms.Button();
            this.buttonGuestList = new System.Windows.Forms.Button();
            this.buttonImage = new System.Windows.Forms.Button();
            this.buttonRooms = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPersonal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 144);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.buttonPersonal);
            this.panel1.Controls.Add(this.buttonReservation);
            this.panel1.Controls.Add(this.buttonGuestList);
            this.panel1.Controls.Add(this.buttonImage);
            this.panel1.Controls.Add(this.buttonRooms);
            this.panel1.Controls.Add(this.buttonType);
            this.panel1.Location = new System.Drawing.Point(0, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 460);
            this.panel1.TabIndex = 1;
            // 
            // buttonReservation
            // 
            this.buttonReservation.BackColor = System.Drawing.Color.Transparent;
            this.buttonReservation.FlatAppearance.BorderSize = 0;
            this.buttonReservation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonReservation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReservation.ForeColor = System.Drawing.Color.Black;
            this.buttonReservation.Location = new System.Drawing.Point(0, 260);
            this.buttonReservation.Name = "buttonReservation";
            this.buttonReservation.Size = new System.Drawing.Size(256, 59);
            this.buttonReservation.TabIndex = 3;
            this.buttonReservation.Text = "Бронювання";
            this.buttonReservation.UseVisualStyleBackColor = false;
            this.buttonReservation.Click += new System.EventHandler(this.buttonReservation_Click);
            // 
            // buttonGuestList
            // 
            this.buttonGuestList.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuestList.FlatAppearance.BorderSize = 0;
            this.buttonGuestList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonGuestList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonGuestList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuestList.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGuestList.ForeColor = System.Drawing.Color.Black;
            this.buttonGuestList.Location = new System.Drawing.Point(0, 195);
            this.buttonGuestList.Name = "buttonGuestList";
            this.buttonGuestList.Size = new System.Drawing.Size(256, 59);
            this.buttonGuestList.TabIndex = 2;
            this.buttonGuestList.Text = "Список гостей";
            this.buttonGuestList.UseVisualStyleBackColor = false;
            this.buttonGuestList.Click += new System.EventHandler(this.buttonGuestList_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.BackColor = System.Drawing.Color.Transparent;
            this.buttonImage.FlatAppearance.BorderSize = 0;
            this.buttonImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonImage.ForeColor = System.Drawing.Color.Black;
            this.buttonImage.Location = new System.Drawing.Point(0, 130);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(256, 59);
            this.buttonImage.TabIndex = 2;
            this.buttonImage.Text = " Фото кімнат";
            this.buttonImage.UseVisualStyleBackColor = false;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonRooms
            // 
            this.buttonRooms.BackColor = System.Drawing.Color.Transparent;
            this.buttonRooms.FlatAppearance.BorderSize = 0;
            this.buttonRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRooms.ForeColor = System.Drawing.Color.Black;
            this.buttonRooms.Location = new System.Drawing.Point(0, 65);
            this.buttonRooms.Name = "buttonRooms";
            this.buttonRooms.Size = new System.Drawing.Size(256, 59);
            this.buttonRooms.TabIndex = 2;
            this.buttonRooms.Text = "Кімнати";
            this.buttonRooms.UseVisualStyleBackColor = false;
            this.buttonRooms.Click += new System.EventHandler(this.buttonRooms_Click);
            // 
            // buttonType
            // 
            this.buttonType.BackColor = System.Drawing.Color.Transparent;
            this.buttonType.FlatAppearance.BorderSize = 0;
            this.buttonType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonType.ForeColor = System.Drawing.Color.Black;
            this.buttonType.Location = new System.Drawing.Point(0, 0);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(256, 59);
            this.buttonType.TabIndex = 0;
            this.buttonType.Text = "  Тип кімнат";
            this.buttonType.UseVisualStyleBackColor = false;
            this.buttonType.Click += new System.EventHandler(this.buttonType_Click);
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClose.ForeColor = System.Drawing.Color.Orange;
            this.labelClose.Location = new System.Drawing.Point(919, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(41, 46);
            this.labelClose.TabIndex = 12;
            this.labelClose.Text = "х";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 100.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(324, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 270);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 70.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(282, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(661, 189);
            this.label2.TabIndex = 14;
            this.label2.Text = "California";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 79.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(406, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(424, 215);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hotel";
            // 
            // buttonPersonal
            // 
            this.buttonPersonal.BackColor = System.Drawing.Color.Transparent;
            this.buttonPersonal.FlatAppearance.BorderSize = 0;
            this.buttonPersonal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonPersonal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPersonal.ForeColor = System.Drawing.Color.Black;
            this.buttonPersonal.Location = new System.Drawing.Point(0, 325);
            this.buttonPersonal.Name = "buttonPersonal";
            this.buttonPersonal.Size = new System.Drawing.Size(256, 59);
            this.buttonPersonal.TabIndex = 4;
            this.buttonPersonal.Text = "Персонал";
            this.buttonPersonal.UseVisualStyleBackColor = false;
            this.buttonPersonal.Click += new System.EventHandler(this.buttonPersonal_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(960, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.Button buttonGuestList;
        private System.Windows.Forms.Button buttonImage;
        private System.Windows.Forms.Button buttonRooms;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReservation;
        private System.Windows.Forms.Button buttonPersonal;
    }
}