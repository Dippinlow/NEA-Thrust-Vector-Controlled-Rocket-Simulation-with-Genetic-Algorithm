namespace Rocket_Advancement_2._5
{
    partial class ControlForm
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
            this.show_all_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_gravity = new System.Windows.Forms.TextBox();
            this.btn_landing = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeWarpTrack = new System.Windows.Forms.TrackBar();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_rocket_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.txt_pop_size = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ux_box = new System.Windows.Forms.TextBox();
            this.txt_uy_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TimeWarpTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(260, 224);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(100, 33);
            this.show_all_btn.TabIndex = 4;
            this.show_all_btn.Text = "Show All";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gravity";
            // 
            // txt_gravity
            // 
            this.txt_gravity.Location = new System.Drawing.Point(12, 314);
            this.txt_gravity.Name = "txt_gravity";
            this.txt_gravity.Size = new System.Drawing.Size(100, 23);
            this.txt_gravity.TabIndex = 8;
            this.txt_gravity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_gravity_KeyPress);
            // 
            // btn_landing
            // 
            this.btn_landing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_landing.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_landing.Location = new System.Drawing.Point(12, 12);
            this.btn_landing.Name = "btn_landing";
            this.btn_landing.Size = new System.Drawing.Size(100, 100);
            this.btn_landing.TabIndex = 9;
            this.btn_landing.Text = "Is Landing?";
            this.btn_landing.UseVisualStyleBackColor = false;
            this.btn_landing.Click += new System.EventHandler(this.btn_landing_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(136, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Time Warp";
            // 
            // TimeWarpTrack
            // 
            this.TimeWarpTrack.Location = new System.Drawing.Point(136, 173);
            this.TimeWarpTrack.Maximum = 8;
            this.TimeWarpTrack.Minimum = 1;
            this.TimeWarpTrack.Name = "TimeWarpTrack";
            this.TimeWarpTrack.Size = new System.Drawing.Size(100, 45);
            this.TimeWarpTrack.TabIndex = 17;
            this.TimeWarpTrack.Value = 1;
            this.TimeWarpTrack.Scroll += new System.EventHandler(this.TimeWarpTrack_Scroll);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_reset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_reset.Location = new System.Drawing.Point(260, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(100, 100);
            this.btn_reset.TabIndex = 20;
            this.btn_reset.Text = "Reset Population";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(136, 314);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(100, 23);
            this.txt_time.TabIndex = 22;
            this.txt_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_time_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(136, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Total Time";
            // 
            // btn_move
            // 
            this.btn_move.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_move.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_move.Location = new System.Drawing.Point(136, 12);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(100, 100);
            this.btn_move.TabIndex = 23;
            this.btn_move.Text = "Auto Move Target";
            this.btn_move.UseVisualStyleBackColor = false;
            this.btn_move.Click += new System.EventHandler(this.btn_move_Click);
            // 
            // btn_rocket_edit
            // 
            this.btn_rocket_edit.Location = new System.Drawing.Point(260, 118);
            this.btn_rocket_edit.Name = "btn_rocket_edit";
            this.btn_rocket_edit.Size = new System.Drawing.Size(100, 100);
            this.btn_rocket_edit.TabIndex = 24;
            this.btn_rocket_edit.Text = "Edit Rocket Properties";
            this.btn_rocket_edit.UseVisualStyleBackColor = true;
            this.btn_rocket_edit.Click += new System.EventHandler(this.btn_rocket_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(12, 118);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 50);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "Save Rocket Properties";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 168);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(100, 50);
            this.btn_load.TabIndex = 27;
            this.btn_load.Text = "Load Rocket Properties";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // txt_pop_size
            // 
            this.txt_pop_size.Location = new System.Drawing.Point(260, 314);
            this.txt_pop_size.Name = "txt_pop_size";
            this.txt_pop_size.Size = new System.Drawing.Size(100, 23);
            this.txt_pop_size.TabIndex = 29;
            this.txt_pop_size.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pop_size_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(260, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Population Size";
            // 
            // txt_ux_box
            // 
            this.txt_ux_box.Location = new System.Drawing.Point(136, 224);
            this.txt_ux_box.Name = "txt_ux_box";
            this.txt_ux_box.Size = new System.Drawing.Size(100, 23);
            this.txt_ux_box.TabIndex = 30;
            this.txt_ux_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ux_box_KeyPress);
            // 
            // txt_uy_box
            // 
            this.txt_uy_box.Location = new System.Drawing.Point(136, 253);
            this.txt_uy_box.Name = "txt_uy_box";
            this.txt_uy_box.Size = new System.Drawing.Size(100, 23);
            this.txt_uy_box.TabIndex = 31;
            this.txt_uy_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_uy_box_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 32;
            this.label4.Text = "Initial X Vel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 33;
            this.label5.Text = "Initial Y Vel";
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_uy_box);
            this.Controls.Add(this.txt_ux_box);
            this.Controls.Add(this.txt_pop_size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_rocket_edit);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.TimeWarpTrack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_landing);
            this.Controls.Add(this.txt_gravity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.show_all_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlForm";
            this.ShowIcon = false;
            this.Text = "ControlForm";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TimeWarpTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button show_all_btn;
        private Label label3;
        private TextBox txt_gravity;
        private Button btn_landing;
        private Label label6;
        private TrackBar TimeWarpTrack;
        private Button btn_reset;
        private TextBox txt_time;
        private Label label1;
        private Button btn_move;
        private Button btn_rocket_edit;
        private Button btn_save;
        private Button btn_load;
        private TextBox txt_pop_size;
        private Label label2;
        private TextBox txt_ux_box;
        private TextBox txt_uy_box;
        private Label label4;
        private Label label5;
    }
}