using System.Windows.Forms;

namespace finalCafeApp
{
    partial class shopTill
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
            this.setMenuBox = new System.Windows.Forms.GroupBox();
            this.teaOrCoffee = new System.Windows.Forms.Button();
            this.bottles = new System.Windows.Forms.Button();
            this.soup = new System.Windows.Forms.Button();
            this.panini = new System.Windows.Forms.Button();
            this.pizza = new System.Windows.Forms.Button();
            this.toppings = new System.Windows.Forms.Button();
            this.bakedPotato = new System.Windows.Forms.Button();
            this.sodas = new System.Windows.Forms.Button();
            this.chips = new System.Windows.Forms.Button();
            this.curryAndRice = new System.Windows.Forms.Button();
            this.fry = new System.Windows.Forms.Button();
            this.sausageRolls = new System.Windows.Forms.Button();
            this.calculatorBox = new System.Windows.Forms.GroupBox();
            this.nineButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.periodButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.clearCalculator = new System.Windows.Forms.Button();
            this.ItemCart = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearCart = new System.Windows.Forms.Button();
            this.RemoveLastItem = new System.Windows.Forms.Button();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.changeCalculationInput = new System.Windows.Forms.ListBox();
            this.changeCalculationOutput = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setMenuBox.SuspendLayout();
            this.calculatorBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setMenuBox
            // 
            this.setMenuBox.Controls.Add(this.teaOrCoffee);
            this.setMenuBox.Controls.Add(this.bottles);
            this.setMenuBox.Controls.Add(this.soup);
            this.setMenuBox.Controls.Add(this.panini);
            this.setMenuBox.Controls.Add(this.pizza);
            this.setMenuBox.Controls.Add(this.toppings);
            this.setMenuBox.Controls.Add(this.bakedPotato);
            this.setMenuBox.Controls.Add(this.sodas);
            this.setMenuBox.Controls.Add(this.chips);
            this.setMenuBox.Controls.Add(this.curryAndRice);
            this.setMenuBox.Controls.Add(this.fry);
            this.setMenuBox.Controls.Add(this.sausageRolls);
            this.setMenuBox.Location = new System.Drawing.Point(12, 11);
            this.setMenuBox.Name = "setMenuBox";
            this.setMenuBox.Size = new System.Drawing.Size(488, 244);
            this.setMenuBox.TabIndex = 0;
            this.setMenuBox.TabStop = false;
            this.setMenuBox.Text = "Set Menu";
            // 
            // teaOrCoffee
            // 
            this.teaOrCoffee.Location = new System.Drawing.Point(386, 173);
            this.teaOrCoffee.Name = "teaOrCoffee";
            this.teaOrCoffee.Size = new System.Drawing.Size(96, 57);
            this.teaOrCoffee.TabIndex = 11;
            this.teaOrCoffee.Text = "Tea/Coffee";
            this.teaOrCoffee.UseVisualStyleBackColor = true;
            this.teaOrCoffee.Click += new System.EventHandler(this.teaOrCoffee_Click);
            // 
            // bottles
            // 
            this.bottles.Location = new System.Drawing.Point(263, 173);
            this.bottles.Name = "bottles";
            this.bottles.Size = new System.Drawing.Size(96, 57);
            this.bottles.TabIndex = 10;
            this.bottles.Text = "Bottles";
            this.bottles.UseVisualStyleBackColor = true;
            this.bottles.Click += new System.EventHandler(this.bottles_Click);
            // 
            // soup
            // 
            this.soup.Location = new System.Drawing.Point(142, 173);
            this.soup.Name = "soup";
            this.soup.Size = new System.Drawing.Size(96, 57);
            this.soup.TabIndex = 9;
            this.soup.Text = "Soup";
            this.soup.UseVisualStyleBackColor = true;
            this.soup.Click += new System.EventHandler(this.soup_Click);
            // 
            // panini
            // 
            this.panini.Location = new System.Drawing.Point(16, 173);
            this.panini.Name = "panini";
            this.panini.Size = new System.Drawing.Size(96, 57);
            this.panini.TabIndex = 8;
            this.panini.Text = "Panini";
            this.panini.UseVisualStyleBackColor = true;
            this.panini.Click += new System.EventHandler(this.panini_Click);
            // 
            // pizza
            // 
            this.pizza.Location = new System.Drawing.Point(386, 96);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(96, 57);
            this.pizza.TabIndex = 7;
            this.pizza.Text = "Pizza";
            this.pizza.UseVisualStyleBackColor = true;
            this.pizza.Click += new System.EventHandler(this.pizza_Click);
            // 
            // toppings
            // 
            this.toppings.Location = new System.Drawing.Point(263, 96);
            this.toppings.Name = "toppings";
            this.toppings.Size = new System.Drawing.Size(96, 57);
            this.toppings.TabIndex = 6;
            this.toppings.Text = "Toppings";
            this.toppings.UseVisualStyleBackColor = true;
            this.toppings.Click += new System.EventHandler(this.toppings_Click);
            // 
            // bakedPotato
            // 
            this.bakedPotato.Location = new System.Drawing.Point(142, 96);
            this.bakedPotato.Name = "bakedPotato";
            this.bakedPotato.Size = new System.Drawing.Size(96, 57);
            this.bakedPotato.TabIndex = 5;
            this.bakedPotato.Text = "Baked Potato";
            this.bakedPotato.UseVisualStyleBackColor = true;
            this.bakedPotato.Click += new System.EventHandler(this.bakedPotato_Click);
            // 
            // sodas
            // 
            this.sodas.Location = new System.Drawing.Point(16, 96);
            this.sodas.Name = "sodas";
            this.sodas.Size = new System.Drawing.Size(96, 57);
            this.sodas.TabIndex = 4;
            this.sodas.Text = "Sodas";
            this.sodas.UseVisualStyleBackColor = true;
            this.sodas.Click += new System.EventHandler(this.sodas_Click);
            // 
            // chips
            // 
            this.chips.Location = new System.Drawing.Point(385, 22);
            this.chips.Name = "chips";
            this.chips.Size = new System.Drawing.Size(96, 57);
            this.chips.TabIndex = 3;
            this.chips.Text = "Chips";
            this.chips.UseVisualStyleBackColor = true;
            this.chips.Click += new System.EventHandler(this.chips_Click);
            // 
            // curryAndRice
            // 
            this.curryAndRice.Location = new System.Drawing.Point(263, 22);
            this.curryAndRice.Name = "curryAndRice";
            this.curryAndRice.Size = new System.Drawing.Size(96, 57);
            this.curryAndRice.TabIndex = 2;
            this.curryAndRice.Text = "Curry and Rice";
            this.curryAndRice.UseVisualStyleBackColor = true;
            this.curryAndRice.Click += new System.EventHandler(this.curryAndRice_Click);
            // 
            // fry
            // 
            this.fry.Location = new System.Drawing.Point(142, 22);
            this.fry.Name = "fry";
            this.fry.Size = new System.Drawing.Size(96, 57);
            this.fry.TabIndex = 1;
            this.fry.Text = "Fry";
            this.fry.UseVisualStyleBackColor = true;
            this.fry.Click += new System.EventHandler(this.fry_Click);
            // 
            // sausageRolls
            // 
            this.sausageRolls.Location = new System.Drawing.Point(16, 22);
            this.sausageRolls.Name = "sausageRolls";
            this.sausageRolls.Size = new System.Drawing.Size(96, 57);
            this.sausageRolls.TabIndex = 0;
            this.sausageRolls.Text = "Sausage Rolls";
            this.sausageRolls.UseVisualStyleBackColor = true;
            this.sausageRolls.Click += new System.EventHandler(this.sausageRolls_Click);
            // 
            // calculatorBox
            // 
            this.calculatorBox.Controls.Add(this.nineButton);
            this.calculatorBox.Controls.Add(this.sixButton);
            this.calculatorBox.Controls.Add(this.eightButton);
            this.calculatorBox.Controls.Add(this.fiveButton);
            this.calculatorBox.Controls.Add(this.sevenButton);
            this.calculatorBox.Controls.Add(this.fourButton);
            this.calculatorBox.Controls.Add(this.oneButton);
            this.calculatorBox.Controls.Add(this.twoButton);
            this.calculatorBox.Controls.Add(this.threeButton);
            this.calculatorBox.Controls.Add(this.periodButton);
            this.calculatorBox.Controls.Add(this.zeroButton);
            this.calculatorBox.Controls.Add(this.clearCalculator);
            this.calculatorBox.Location = new System.Drawing.Point(1017, 267);
            this.calculatorBox.Name = "calculatorBox";
            this.calculatorBox.Size = new System.Drawing.Size(284, 328);
            this.calculatorBox.TabIndex = 1;
            this.calculatorBox.TabStop = false;
            this.calculatorBox.Text = "Change Calculator";
            // 
            // nineButton
            // 
            this.nineButton.Location = new System.Drawing.Point(191, 19);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(66, 61);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.nineButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.Location = new System.Drawing.Point(191, 91);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(66, 61);
            this.sixButton.TabIndex = 9;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.sixButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.Location = new System.Drawing.Point(102, 19);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(66, 61);
            this.eightButton.TabIndex = 8;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.eightButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.Location = new System.Drawing.Point(102, 91);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(66, 61);
            this.fiveButton.TabIndex = 7;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.fiveButton_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.Location = new System.Drawing.Point(15, 19);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(66, 61);
            this.sevenButton.TabIndex = 6;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.sevenButton_Click);
            // 
            // fourButton
            // 
            this.fourButton.Location = new System.Drawing.Point(15, 93);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(66, 61);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.fourButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.Location = new System.Drawing.Point(15, 172);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(66, 61);
            this.oneButton.TabIndex = 4;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.oneButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.Location = new System.Drawing.Point(102, 172);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(66, 61);
            this.twoButton.TabIndex = 4;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.twoButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.Location = new System.Drawing.Point(191, 172);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(66, 61);
            this.threeButton.TabIndex = 3;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.threeButton_Click);
            // 
            // periodButton
            // 
            this.periodButton.Location = new System.Drawing.Point(15, 250);
            this.periodButton.Name = "periodButton";
            this.periodButton.Size = new System.Drawing.Size(66, 61);
            this.periodButton.TabIndex = 2;
            this.periodButton.Text = ".";
            this.periodButton.UseVisualStyleBackColor = true;
            this.periodButton.Click += new System.EventHandler(this.periodButton_Click);
            // 
            // zeroButton
            // 
            this.zeroButton.Location = new System.Drawing.Point(102, 250);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(66, 61);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // clearCalculator
            // 
            this.clearCalculator.Location = new System.Drawing.Point(191, 250);
            this.clearCalculator.Name = "clearCalculator";
            this.clearCalculator.Size = new System.Drawing.Size(66, 61);
            this.clearCalculator.TabIndex = 0;
            this.clearCalculator.Text = "Clear";
            this.clearCalculator.UseVisualStyleBackColor = true;
            this.clearCalculator.Click += new System.EventHandler(this.clearCalculator_Click);
            // 
            // ItemCart
            // 
            this.ItemCart.FormattingEnabled = true;
            this.ItemCart.Location = new System.Drawing.Point(259, 332);
            this.ItemCart.Name = "ItemCart";
            this.ItemCart.Size = new System.Drawing.Size(235, 303);
            this.ItemCart.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearCart);
            this.groupBox1.Controls.Add(this.RemoveLastItem);
            this.groupBox1.Controls.Add(this.checkoutButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 367);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "controlsBox";
            // 
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(13, 199);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(203, 71);
            this.clearCart.TabIndex = 2;
            this.clearCart.Text = "Clear Cart";
            this.clearCart.UseVisualStyleBackColor = true;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
            // 
            // RemoveLastItem
            // 
            this.RemoveLastItem.Location = new System.Drawing.Point(13, 109);
            this.RemoveLastItem.Name = "RemoveLastItem";
            this.RemoveLastItem.Size = new System.Drawing.Size(203, 71);
            this.RemoveLastItem.TabIndex = 1;
            this.RemoveLastItem.Text = "Remove Last Item";
            this.RemoveLastItem.UseVisualStyleBackColor = true;
            this.RemoveLastItem.Click += new System.EventHandler(this.RemoveLastItem_Click);
            // 
            // checkoutButton
            // 
            this.checkoutButton.Location = new System.Drawing.Point(13, 19);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(203, 71);
            this.checkoutButton.TabIndex = 0;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // changeCalculationInput
            // 
            this.changeCalculationInput.FormattingEnabled = true;
            this.changeCalculationInput.Location = new System.Drawing.Point(517, 352);
            this.changeCalculationInput.Name = "changeCalculationInput";
            this.changeCalculationInput.Size = new System.Drawing.Size(447, 69);
            this.changeCalculationInput.TabIndex = 4;
            // 
            // changeCalculationOutput
            // 
            this.changeCalculationOutput.FormattingEnabled = true;
            this.changeCalculationOutput.Location = new System.Drawing.Point(517, 509);
            this.changeCalculationOutput.Name = "changeCalculationOutput";
            this.changeCalculationOutput.Size = new System.Drawing.Size(447, 69);
            this.changeCalculationOutput.TabIndex = 5;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.Location = new System.Drawing.Point(262, 273);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(66, 31);
            this.lblCart.TabIndex = 6;
            this.lblCart.Text = "Cart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Change Calculator Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(516, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Change Calculator Output";
            // 
            // shopTill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1313, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.changeCalculationOutput);
            this.Controls.Add(this.changeCalculationInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ItemCart);
            this.Controls.Add(this.calculatorBox);
            this.Controls.Add(this.setMenuBox);
            this.Name = "shopTill";
            this.Text = "Shop Till";
            this.Load += new System.EventHandler(this.shopTill_Load);
            this.setMenuBox.ResumeLayout(false);
            this.calculatorBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox setMenuBox;
        private System.Windows.Forms.Button teaOrCoffee;
        private System.Windows.Forms.Button bottles;
        private System.Windows.Forms.Button soup;
        private System.Windows.Forms.Button panini;
        private System.Windows.Forms.Button pizza;
        private System.Windows.Forms.Button toppings;
        private System.Windows.Forms.Button bakedPotato;
        private System.Windows.Forms.Button sodas;
        private System.Windows.Forms.Button chips;
        private System.Windows.Forms.Button curryAndRice;
        private System.Windows.Forms.Button fry;
        private System.Windows.Forms.Button sausageRolls;
        private System.Windows.Forms.GroupBox calculatorBox;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button periodButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button clearCalculator;
        private ListBox ItemCart;
        private System.Windows.Forms.ListBox itemCart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearCart;
        private Button RemoveLastItem;
        private System.Windows.Forms.Button removeLastItem;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.ListBox changeCalculationInput;
        private System.Windows.Forms.ListBox changeCalculationOutput;
        private Label lblCart;
        private Label label1;
        private Label label2;
    }
}

