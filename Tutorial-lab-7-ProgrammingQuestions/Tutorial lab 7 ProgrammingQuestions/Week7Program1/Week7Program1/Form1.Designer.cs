namespace Week8Program1
{
    partial class Form1
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.teaCoffeeCB = new System.Windows.Forms.CheckBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.menuGroupBox = new System.Windows.Forms.GroupBox();
            this.drinksCB = new System.Windows.Forms.CheckBox();
            this.pizzaCB = new System.Windows.Forms.CheckBox();
            this.sushiCB = new System.Windows.Forms.CheckBox();
            this.cerealCB = new System.Windows.Forms.CheckBox();
            this.banBreadCB = new System.Windows.Forms.CheckBox();
            this.juiceCB = new System.Windows.Forms.CheckBox();
            this.priceTitleLabel = new System.Windows.Forms.Label();
            this.itemTitleLabel = new System.Windows.Forms.Label();
            this.teaCoffeePLbl = new System.Windows.Forms.Label();
            this.juicePLbl = new System.Windows.Forms.Label();
            this.banBreadPLbl = new System.Windows.Forms.Label();
            this.cerealPLbl = new System.Windows.Forms.Label();
            this.sushiPLbl = new System.Windows.Forms.Label();
            this.pizzaPLbl = new System.Windows.Forms.Label();
            this.drinksPLbl = new System.Windows.Forms.Label();
            this.menuGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(106, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(234, 29);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Student Restaurant";
            // 
            // teaCoffeeCB
            // 
            this.teaCoffeeCB.AutoSize = true;
            this.teaCoffeeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaCoffeeCB.Location = new System.Drawing.Point(6, 78);
            this.teaCoffeeCB.Name = "teaCoffeeCB";
            this.teaCoffeeCB.Size = new System.Drawing.Size(100, 21);
            this.teaCoffeeCB.TabIndex = 1;
            this.teaCoffeeCB.Text = "Tea/Coffee";
            this.teaCoffeeCB.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(273, 531);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(118, 48);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(71, 531);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(118, 48);
            this.orderButton.TabIndex = 3;
            this.orderButton.Text = "Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // menuGroupBox
            // 
            this.menuGroupBox.Controls.Add(this.drinksPLbl);
            this.menuGroupBox.Controls.Add(this.pizzaPLbl);
            this.menuGroupBox.Controls.Add(this.sushiPLbl);
            this.menuGroupBox.Controls.Add(this.cerealPLbl);
            this.menuGroupBox.Controls.Add(this.banBreadPLbl);
            this.menuGroupBox.Controls.Add(this.juicePLbl);
            this.menuGroupBox.Controls.Add(this.teaCoffeePLbl);
            this.menuGroupBox.Controls.Add(this.drinksCB);
            this.menuGroupBox.Controls.Add(this.pizzaCB);
            this.menuGroupBox.Controls.Add(this.sushiCB);
            this.menuGroupBox.Controls.Add(this.cerealCB);
            this.menuGroupBox.Controls.Add(this.banBreadCB);
            this.menuGroupBox.Controls.Add(this.juiceCB);
            this.menuGroupBox.Controls.Add(this.priceTitleLabel);
            this.menuGroupBox.Controls.Add(this.itemTitleLabel);
            this.menuGroupBox.Controls.Add(this.teaCoffeeCB);
            this.menuGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuGroupBox.Location = new System.Drawing.Point(76, 119);
            this.menuGroupBox.Name = "menuGroupBox";
            this.menuGroupBox.Size = new System.Drawing.Size(315, 349);
            this.menuGroupBox.TabIndex = 4;
            this.menuGroupBox.TabStop = false;
            this.menuGroupBox.Text = "Menu";
            // 
            // drinksCB
            // 
            this.drinksCB.AutoSize = true;
            this.drinksCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksCB.Location = new System.Drawing.Point(6, 303);
            this.drinksCB.Name = "drinksCB";
            this.drinksCB.Size = new System.Drawing.Size(70, 21);
            this.drinksCB.TabIndex = 9;
            this.drinksCB.Text = "Drinks";
            this.drinksCB.UseVisualStyleBackColor = true;
            // 
            // pizzaCB
            // 
            this.pizzaCB.AutoSize = true;
            this.pizzaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaCB.Location = new System.Drawing.Point(6, 266);
            this.pizzaCB.Name = "pizzaCB";
            this.pizzaCB.Size = new System.Drawing.Size(64, 21);
            this.pizzaCB.TabIndex = 8;
            this.pizzaCB.Text = "Pizza";
            this.pizzaCB.UseVisualStyleBackColor = true;
            // 
            // sushiCB
            // 
            this.sushiCB.AutoSize = true;
            this.sushiCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushiCB.Location = new System.Drawing.Point(6, 227);
            this.sushiCB.Name = "sushiCB";
            this.sushiCB.Size = new System.Drawing.Size(65, 21);
            this.sushiCB.TabIndex = 7;
            this.sushiCB.Text = "Sushi";
            this.sushiCB.UseVisualStyleBackColor = true;
            // 
            // cerealCB
            // 
            this.cerealCB.AutoSize = true;
            this.cerealCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerealCB.Location = new System.Drawing.Point(6, 190);
            this.cerealCB.Name = "cerealCB";
            this.cerealCB.Size = new System.Drawing.Size(71, 21);
            this.cerealCB.TabIndex = 6;
            this.cerealCB.Text = "Cereal";
            this.cerealCB.UseVisualStyleBackColor = true;
            // 
            // banBreadCB
            // 
            this.banBreadCB.AutoSize = true;
            this.banBreadCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banBreadCB.Location = new System.Drawing.Point(6, 152);
            this.banBreadCB.Name = "banBreadCB";
            this.banBreadCB.Size = new System.Drawing.Size(121, 21);
            this.banBreadCB.TabIndex = 5;
            this.banBreadCB.Text = "Banana Bread";
            this.banBreadCB.UseVisualStyleBackColor = true;
            // 
            // juiceCB
            // 
            this.juiceCB.AutoSize = true;
            this.juiceCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juiceCB.Location = new System.Drawing.Point(6, 116);
            this.juiceCB.Name = "juiceCB";
            this.juiceCB.Size = new System.Drawing.Size(63, 21);
            this.juiceCB.TabIndex = 4;
            this.juiceCB.Text = "Juice";
            this.juiceCB.UseVisualStyleBackColor = true;
            // 
            // priceTitleLabel
            // 
            this.priceTitleLabel.AutoSize = true;
            this.priceTitleLabel.Location = new System.Drawing.Point(205, 36);
            this.priceTitleLabel.Name = "priceTitleLabel";
            this.priceTitleLabel.Size = new System.Drawing.Size(59, 17);
            this.priceTitleLabel.TabIndex = 3;
            this.priceTitleLabel.Text = "Price $";
            // 
            // itemTitleLabel
            // 
            this.itemTitleLabel.AutoSize = true;
            this.itemTitleLabel.Location = new System.Drawing.Point(32, 36);
            this.itemTitleLabel.Name = "itemTitleLabel";
            this.itemTitleLabel.Size = new System.Drawing.Size(38, 17);
            this.itemTitleLabel.TabIndex = 2;
            this.itemTitleLabel.Text = "Item";
            // 
            // teaCoffeePLbl
            // 
            this.teaCoffeePLbl.AutoSize = true;
            this.teaCoffeePLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teaCoffeePLbl.Location = new System.Drawing.Point(228, 79);
            this.teaCoffeePLbl.Name = "teaCoffeePLbl";
            this.teaCoffeePLbl.Size = new System.Drawing.Size(36, 17);
            this.teaCoffeePLbl.TabIndex = 10;
            this.teaCoffeePLbl.Text = "4.80";
            // 
            // juicePLbl
            // 
            this.juicePLbl.AutoSize = true;
            this.juicePLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juicePLbl.Location = new System.Drawing.Point(228, 117);
            this.juicePLbl.Name = "juicePLbl";
            this.juicePLbl.Size = new System.Drawing.Size(36, 17);
            this.juicePLbl.TabIndex = 11;
            this.juicePLbl.Text = "3.50";
            // 
            // banBreadPLbl
            // 
            this.banBreadPLbl.AutoSize = true;
            this.banBreadPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banBreadPLbl.Location = new System.Drawing.Point(228, 153);
            this.banBreadPLbl.Name = "banBreadPLbl";
            this.banBreadPLbl.Size = new System.Drawing.Size(36, 17);
            this.banBreadPLbl.TabIndex = 12;
            this.banBreadPLbl.Text = "2.50";
            // 
            // cerealPLbl
            // 
            this.cerealPLbl.AutoSize = true;
            this.cerealPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerealPLbl.Location = new System.Drawing.Point(228, 191);
            this.cerealPLbl.Name = "cerealPLbl";
            this.cerealPLbl.Size = new System.Drawing.Size(36, 17);
            this.cerealPLbl.TabIndex = 13;
            this.cerealPLbl.Text = "5.50";
            // 
            // sushiPLbl
            // 
            this.sushiPLbl.AutoSize = true;
            this.sushiPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sushiPLbl.Location = new System.Drawing.Point(228, 228);
            this.sushiPLbl.Name = "sushiPLbl";
            this.sushiPLbl.Size = new System.Drawing.Size(36, 17);
            this.sushiPLbl.TabIndex = 14;
            this.sushiPLbl.Text = "3.00";
            // 
            // pizzaPLbl
            // 
            this.pizzaPLbl.AutoSize = true;
            this.pizzaPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaPLbl.Location = new System.Drawing.Point(228, 267);
            this.pizzaPLbl.Name = "pizzaPLbl";
            this.pizzaPLbl.Size = new System.Drawing.Size(36, 17);
            this.pizzaPLbl.TabIndex = 15;
            this.pizzaPLbl.Text = "9.00";
            // 
            // drinksPLbl
            // 
            this.drinksPLbl.AutoSize = true;
            this.drinksPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinksPLbl.Location = new System.Drawing.Point(228, 304);
            this.drinksPLbl.Name = "drinksPLbl";
            this.drinksPLbl.Size = new System.Drawing.Size(36, 17);
            this.drinksPLbl.TabIndex = 16;
            this.drinksPLbl.Text = "3.50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 663);
            this.Controls.Add(this.menuGroupBox);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuGroupBox.ResumeLayout(false);
            this.menuGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.CheckBox teaCoffeeCB;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.GroupBox menuGroupBox;
        private System.Windows.Forms.Label priceTitleLabel;
        private System.Windows.Forms.Label itemTitleLabel;
        private System.Windows.Forms.CheckBox drinksCB;
        private System.Windows.Forms.CheckBox pizzaCB;
        private System.Windows.Forms.CheckBox sushiCB;
        private System.Windows.Forms.CheckBox cerealCB;
        private System.Windows.Forms.CheckBox banBreadCB;
        private System.Windows.Forms.CheckBox juiceCB;
        private System.Windows.Forms.Label teaCoffeePLbl;
        private System.Windows.Forms.Label drinksPLbl;
        private System.Windows.Forms.Label pizzaPLbl;
        private System.Windows.Forms.Label sushiPLbl;
        private System.Windows.Forms.Label cerealPLbl;
        private System.Windows.Forms.Label banBreadPLbl;
        private System.Windows.Forms.Label juicePLbl;
    }
}

