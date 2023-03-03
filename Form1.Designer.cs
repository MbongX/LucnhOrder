namespace LucnhOrder
{
    partial class LunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSalad = new System.Windows.Forms.RadioButton();
            this.rbtnPizza = new System.Windows.Forms.RadioButton();
            this.rbtnHamburger = new System.Windows.Forms.RadioButton();
            this.grpbxAddons = new System.Windows.Forms.GroupBox();
            this.cbx3 = new System.Windows.Forms.CheckBox();
            this.cbx2 = new System.Windows.Forms.CheckBox();
            this.cbx1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpbxAddons.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(469, 221);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(138, 38);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(469, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(138, 38);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSalad);
            this.groupBox1.Controls.Add(this.rbtnPizza);
            this.groupBox1.Controls.Add(this.rbtnHamburger);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main course";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnSalad
            // 
            this.rbtnSalad.AutoSize = true;
            this.rbtnSalad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnSalad.Location = new System.Drawing.Point(25, 92);
            this.rbtnSalad.Name = "rbtnSalad";
            this.rbtnSalad.Size = new System.Drawing.Size(116, 23);
            this.rbtnSalad.TabIndex = 2;
            this.rbtnSalad.TabStop = true;
            this.rbtnSalad.Text = "Salad - R45.94";
            this.rbtnSalad.UseVisualStyleBackColor = true;
            this.rbtnSalad.CheckedChanged += new System.EventHandler(this.rbtnSalad_CheckedChanged);
            // 
            // rbtnPizza
            // 
            this.rbtnPizza.AutoSize = true;
            this.rbtnPizza.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnPizza.Location = new System.Drawing.Point(25, 58);
            this.rbtnPizza.Name = "rbtnPizza";
            this.rbtnPizza.Size = new System.Drawing.Size(114, 23);
            this.rbtnPizza.TabIndex = 1;
            this.rbtnPizza.TabStop = true;
            this.rbtnPizza.Text = "Pizza - R19.95";
            this.rbtnPizza.UseVisualStyleBackColor = true;
            this.rbtnPizza.CheckedChanged += new System.EventHandler(this.rbtnPizza_CheckedChanged);
            // 
            // rbtnHamburger
            // 
            this.rbtnHamburger.AutoSize = true;
            this.rbtnHamburger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbtnHamburger.Location = new System.Drawing.Point(25, 27);
            this.rbtnHamburger.Name = "rbtnHamburger";
            this.rbtnHamburger.Size = new System.Drawing.Size(154, 23);
            this.rbtnHamburger.TabIndex = 0;
            this.rbtnHamburger.TabStop = true;
            this.rbtnHamburger.Text = "Hamburger - R54.95";
            this.rbtnHamburger.UseVisualStyleBackColor = true;
            this.rbtnHamburger.CheckedChanged += new System.EventHandler(this.rbtnHamburger_CheckedChanged);
            // 
            // grpbxAddons
            // 
            this.grpbxAddons.Controls.Add(this.cbx3);
            this.grpbxAddons.Controls.Add(this.cbx2);
            this.grpbxAddons.Controls.Add(this.cbx1);
            this.grpbxAddons.Location = new System.Drawing.Point(338, 22);
            this.grpbxAddons.Name = "grpbxAddons";
            this.grpbxAddons.Size = new System.Drawing.Size(269, 131);
            this.grpbxAddons.TabIndex = 3;
            this.grpbxAddons.TabStop = false;
            // 
            // cbx3
            // 
            this.cbx3.AutoSize = true;
            this.cbx3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx3.Location = new System.Drawing.Point(31, 92);
            this.cbx3.Name = "cbx3";
            this.cbx3.Size = new System.Drawing.Size(15, 14);
            this.cbx3.TabIndex = 2;
            this.cbx3.UseVisualStyleBackColor = true;
            this.cbx3.CheckedChanged += new System.EventHandler(this.cbx3_CheckedChanged);
            // 
            // cbx2
            // 
            this.cbx2.AutoSize = true;
            this.cbx2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx2.Location = new System.Drawing.Point(31, 58);
            this.cbx2.Name = "cbx2";
            this.cbx2.Size = new System.Drawing.Size(15, 14);
            this.cbx2.TabIndex = 1;
            this.cbx2.UseVisualStyleBackColor = true;
            this.cbx2.CheckedChanged += new System.EventHandler(this.cbx2_CheckedChanged);
            // 
            // cbx1
            // 
            this.cbx1.AutoSize = true;
            this.cbx1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbx1.Location = new System.Drawing.Point(32, 27);
            this.cbx1.Name = "cbx1";
            this.cbx1.Size = new System.Drawing.Size(15, 14);
            this.cbx1.TabIndex = 0;
            this.cbx1.UseVisualStyleBackColor = true;
            this.cbx1.CheckedChanged += new System.EventHandler(this.cbx1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrderTotal);
            this.groupBox3.Controls.Add(this.txtVAT);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(21, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(414, 161);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(172, 120);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(160, 23);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(172, 77);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(160, 23);
            this.txtVAT.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(172, 30);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(160, 23);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(79, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ordertotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vat (15%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // LunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 378);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpbxAddons);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Name = "LunchOrder";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpbxAddons.ResumeLayout(false);
            this.grpbxAddons.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnPlaceOrder;
        private Button btnExit;
        private GroupBox groupBox1;
        private GroupBox grpbxAddons;
        private GroupBox groupBox3;
        private RadioButton rbtnSalad;
        private RadioButton rbtnPizza;
        private RadioButton rbtnHamburger;
        private CheckBox cbx3;
        private CheckBox cbx2;
        private CheckBox cbx1;
        private TextBox txtOrderTotal;
        private TextBox txtVAT;
        private TextBox txtSubtotal;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}