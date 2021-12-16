
namespace Kursach_2._0
{
    partial class Room_Image_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Room_Image_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBoxImageId = new System.Windows.Forms.ListBox();
            this.pictureBoxRoomIm = new System.Windows.Forms.PictureBox();
            this.buttonAllRooms = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSelectIm = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxType = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomIm)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 144);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.Transparent;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(1359, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(41, 46);
            this.labelClose.TabIndex = 14;
            this.labelClose.Text = "х";
            this.labelClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(584, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 100);
            this.label1.TabIndex = 15;
            this.label1.Text = "Фото кімнат";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 5);
            this.panel2.TabIndex = 27;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOrange;
            this.dataGridView1.Location = new System.Drawing.Point(336, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(392, 438);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // listBoxImageId
            // 
            this.listBoxImageId.BackColor = System.Drawing.Color.White;
            this.listBoxImageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxImageId.ForeColor = System.Drawing.Color.DarkOrange;
            this.listBoxImageId.FormattingEnabled = true;
            this.listBoxImageId.ItemHeight = 31;
            this.listBoxImageId.Location = new System.Drawing.Point(773, 230);
            this.listBoxImageId.Name = "listBoxImageId";
            this.listBoxImageId.Size = new System.Drawing.Size(162, 438);
            this.listBoxImageId.TabIndex = 29;
            this.listBoxImageId.Click += new System.EventHandler(this.listBoxImageId_Click);
            // 
            // pictureBoxRoomIm
            // 
            this.pictureBoxRoomIm.BackColor = System.Drawing.Color.White;
            this.pictureBoxRoomIm.Location = new System.Drawing.Point(974, 230);
            this.pictureBoxRoomIm.Name = "pictureBoxRoomIm";
            this.pictureBoxRoomIm.Size = new System.Drawing.Size(399, 438);
            this.pictureBoxRoomIm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRoomIm.TabIndex = 30;
            this.pictureBoxRoomIm.TabStop = false;
            // 
            // buttonAllRooms
            // 
            this.buttonAllRooms.BackColor = System.Drawing.Color.Transparent;
            this.buttonAllRooms.FlatAppearance.BorderSize = 0;
            this.buttonAllRooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAllRooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAllRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllRooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAllRooms.ForeColor = System.Drawing.Color.Black;
            this.buttonAllRooms.Location = new System.Drawing.Point(369, 674);
            this.buttonAllRooms.Name = "buttonAllRooms";
            this.buttonAllRooms.Size = new System.Drawing.Size(318, 59);
            this.buttonAllRooms.TabIndex = 44;
            this.buttonAllRooms.Text = "Галерея кімнат";
            this.buttonAllRooms.UseVisualStyleBackColor = false;
            this.buttonAllRooms.Click += new System.EventHandler(this.buttonAllRooms_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.Transparent;
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRemove.ForeColor = System.Drawing.Color.Black;
            this.buttonRemove.Location = new System.Drawing.Point(773, 674);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(170, 59);
            this.buttonRemove.TabIndex = 43;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSelectIm
            // 
            this.buttonSelectIm.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelectIm.FlatAppearance.BorderSize = 0;
            this.buttonSelectIm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonSelectIm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonSelectIm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSelectIm.ForeColor = System.Drawing.Color.Black;
            this.buttonSelectIm.Location = new System.Drawing.Point(1061, 165);
            this.buttonSelectIm.Name = "buttonSelectIm";
            this.buttonSelectIm.Size = new System.Drawing.Size(226, 59);
            this.buttonSelectIm.TabIndex = 42;
            this.buttonSelectIm.Text = "Обрати фото";
            this.buttonSelectIm.UseVisualStyleBackColor = false;
            this.buttonSelectIm.Click += new System.EventHandler(this.buttonSelectIm_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.Black;
            this.buttonAdd.Location = new System.Drawing.Point(1098, 674);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(164, 59);
            this.buttonAdd.TabIndex = 41;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(758, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 45;
            this.label2.Text = "Список фото";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(415, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 46;
            this.label3.Text = "Список номерів";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(59, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 32);
            this.label4.TabIndex = 48;
            this.label4.Text = "Список типів";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxType
            // 
            this.listBoxType.BackColor = System.Drawing.Color.White;
            this.listBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxType.ForeColor = System.Drawing.Color.DarkOrange;
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 31;
            this.listBoxType.Location = new System.Drawing.Point(33, 230);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(245, 438);
            this.listBoxType.TabIndex = 47;
            this.listBoxType.Click += new System.EventHandler(this.listBoxType_Click);
            // 
            // Room_Image_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1400, 745);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAllRooms);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonSelectIm);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBoxRoomIm);
            this.Controls.Add(this.listBoxImageId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room_Image_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room_Image_Form";
            this.Load += new System.EventHandler(this.Room_Image_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRoomIm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox listBoxImageId;
        private System.Windows.Forms.PictureBox pictureBoxRoomIm;
        private System.Windows.Forms.Button buttonAllRooms;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSelectIm;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxType;
    }
}