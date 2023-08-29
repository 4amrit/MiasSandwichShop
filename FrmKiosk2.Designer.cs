namespace KisokDemo1
{
    partial class FrmKiosk2
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
            this.tabControlSandwiches = new System.Windows.Forms.TabControl();
            this.Sandwiches = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tunaSandwich = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtB2Description = new System.Windows.Forms.TextBox();
            this.bntSandwich2 = new System.Windows.Forms.Button();
            this.cheeseSandwich = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB1Description = new System.Windows.Forms.TextBox();
            this.btnCheeseSandwich = new System.Windows.Forms.Button();
            this.lstBCart = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.Checkout = new System.Windows.Forms.Button();
            this.tabControlSandwiches.SuspendLayout();
            this.Sandwiches.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tunaSandwich.SuspendLayout();
            this.cheeseSandwich.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSandwiches
            // 
            this.tabControlSandwiches.Controls.Add(this.Sandwiches);
            this.tabControlSandwiches.Location = new System.Drawing.Point(0, 0);
            this.tabControlSandwiches.Name = "tabControlSandwiches";
            this.tabControlSandwiches.SelectedIndex = 0;
            this.tabControlSandwiches.Size = new System.Drawing.Size(760, 527);
            this.tabControlSandwiches.TabIndex = 0;
            // 
            // Sandwiches
            // 
            this.Sandwiches.AutoScroll = true;
            this.Sandwiches.Controls.Add(this.groupBox2);
            this.Sandwiches.Controls.Add(this.groupBox1);
            this.Sandwiches.Controls.Add(this.tunaSandwich);
            this.Sandwiches.Controls.Add(this.cheeseSandwich);
            this.Sandwiches.Location = new System.Drawing.Point(4, 22);
            this.Sandwiches.Name = "Sandwiches";
            this.Sandwiches.Padding = new System.Windows.Forms.Padding(3);
            this.Sandwiches.Size = new System.Drawing.Size(752, 501);
            this.Sandwiches.TabIndex = 0;
            this.Sandwiches.Text = "Sandwiches";
            this.Sandwiches.UseVisualStyleBackColor = true;
            this.Sandwiches.Click += new System.EventHandler(this.Sandwiches_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(379, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 228);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cheese and Pesto Sandwich";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Click image to add to cart";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(208, 30);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 143);
            this.textBox2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 143);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuna Sandwich";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(33, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click image to add to cart";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 143);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 143);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tunaSandwich
            // 
            this.tunaSandwich.Controls.Add(this.label2);
            this.tunaSandwich.Controls.Add(this.txtB2Description);
            this.tunaSandwich.Controls.Add(this.bntSandwich2);
            this.tunaSandwich.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tunaSandwich.Location = new System.Drawing.Point(379, 18);
            this.tunaSandwich.Name = "tunaSandwich";
            this.tunaSandwich.Size = new System.Drawing.Size(355, 228);
            this.tunaSandwich.TabIndex = 3;
            this.tunaSandwich.TabStop = false;
            this.tunaSandwich.Text = "Ham Sandwich";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(33, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click image to add to cart";
            // 
            // txtB2Description
            // 
            this.txtB2Description.Location = new System.Drawing.Point(208, 30);
            this.txtB2Description.Multiline = true;
            this.txtB2Description.Name = "txtB2Description";
            this.txtB2Description.Size = new System.Drawing.Size(121, 143);
            this.txtB2Description.TabIndex = 1;
            // 
            // bntSandwich2
            // 
            this.bntSandwich2.Location = new System.Drawing.Point(16, 30);
            this.bntSandwich2.Name = "bntSandwich2";
            this.bntSandwich2.Size = new System.Drawing.Size(172, 143);
            this.bntSandwich2.TabIndex = 0;
            this.bntSandwich2.UseVisualStyleBackColor = true;
            // 
            // cheeseSandwich
            // 
            this.cheeseSandwich.Controls.Add(this.label1);
            this.cheeseSandwich.Controls.Add(this.txtB1Description);
            this.cheeseSandwich.Controls.Add(this.btnCheeseSandwich);
            this.cheeseSandwich.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheeseSandwich.Location = new System.Drawing.Point(18, 18);
            this.cheeseSandwich.Name = "cheeseSandwich";
            this.cheeseSandwich.Size = new System.Drawing.Size(355, 228);
            this.cheeseSandwich.TabIndex = 0;
            this.cheeseSandwich.TabStop = false;
            this.cheeseSandwich.Text = "BLT Sandwich";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(33, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Click image to add to cart";
            // 
            // txtB1Description
            // 
            this.txtB1Description.Location = new System.Drawing.Point(208, 30);
            this.txtB1Description.Multiline = true;
            this.txtB1Description.Name = "txtB1Description";
            this.txtB1Description.Size = new System.Drawing.Size(121, 143);
            this.txtB1Description.TabIndex = 1;
            // 
            // btnCheeseSandwich
            // 
            this.btnCheeseSandwich.Location = new System.Drawing.Point(16, 30);
            this.btnCheeseSandwich.Name = "btnCheeseSandwich";
            this.btnCheeseSandwich.Size = new System.Drawing.Size(172, 143);
            this.btnCheeseSandwich.TabIndex = 0;
            this.btnCheeseSandwich.UseVisualStyleBackColor = true;
            // 
            // lstBCart
            // 
            this.lstBCart.BackColor = System.Drawing.Color.AliceBlue;
            this.lstBCart.FormattingEnabled = true;
            this.lstBCart.Location = new System.Drawing.Point(766, 22);
            this.lstBCart.Name = "lstBCart";
            this.lstBCart.Size = new System.Drawing.Size(261, 433);
            this.lstBCart.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(766, 501);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(57, 22);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total:";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(766, 461);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(86, 34);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Checkout
            // 
            this.Checkout.Location = new System.Drawing.Point(923, 495);
            this.Checkout.Name = "Checkout";
            this.Checkout.Size = new System.Drawing.Size(98, 36);
            this.Checkout.TabIndex = 5;
            this.Checkout.Text = "Checkout";
            this.Checkout.UseVisualStyleBackColor = true;
            this.Checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // FrmKiosk2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1033, 539);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lstBCart);
            this.Controls.Add(this.tabControlSandwiches);
            this.Name = "FrmKiosk2";
            this.Text = "Mias Sandwich Shop";
            this.Load += new System.EventHandler(this.FrmKiosk2_Load);
            this.tabControlSandwiches.ResumeLayout(false);
            this.Sandwiches.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tunaSandwich.ResumeLayout(false);
            this.tunaSandwich.PerformLayout();
            this.cheeseSandwich.ResumeLayout(false);
            this.cheeseSandwich.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSandwiches;
        private System.Windows.Forms.TabPage Sandwiches;
        private System.Windows.Forms.GroupBox tunaSandwich;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB2Description;
        private System.Windows.Forms.Button bntSandwich2;
        private System.Windows.Forms.GroupBox cheeseSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtB1Description;
        private System.Windows.Forms.Button btnCheeseSandwich;
        private System.Windows.Forms.ListBox lstBCart;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Checkout;
    }
}