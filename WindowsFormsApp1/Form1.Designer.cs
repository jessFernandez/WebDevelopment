namespace WindowsFormsApp1
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
            this.longitude = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.latitude = new System.Windows.Forms.TextBox();
            this.uvIndex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findClosestStore = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.storeName = new System.Windows.Forms.TextBox();
            this.zipCode = new System.Windows.Forms.TextBox();
            this.storeAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ZipCodeBooking = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AddressBooking = new System.Windows.Forms.TextBox();
            this.touristInfo = new System.Windows.Forms.TextBox();
            this.bookingService = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.keyword = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.newsResults = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // longitude
            // 
            this.longitude.Location = new System.Drawing.Point(104, 71);
            this.longitude.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.longitude.Name = "longitude";
            this.longitude.Size = new System.Drawing.Size(89, 20);
            this.longitude.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solar Service";
            // 
            // latitude
            // 
            this.latitude.Location = new System.Drawing.Point(104, 49);
            this.latitude.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.latitude.Name = "latitude";
            this.latitude.Size = new System.Drawing.Size(89, 20);
            this.latitude.TabIndex = 2;
            // 
            // uvIndex
            // 
            this.uvIndex.Location = new System.Drawing.Point(104, 119);
            this.uvIndex.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uvIndex.Name = "uvIndex";
            this.uvIndex.Size = new System.Drawing.Size(89, 20);
            this.uvIndex.TabIndex = 3;
            this.uvIndex.TextChanged += new System.EventHandler(this.UvIndex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Given a Latitude and Longitude return the given UV Index";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 92);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Get UV Index";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Longitude: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Latitude:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "UV Index: ";
            // 
            // findClosestStore
            // 
            this.findClosestStore.Location = new System.Drawing.Point(104, 233);
            this.findClosestStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.findClosestStore.Name = "findClosestStore";
            this.findClosestStore.Size = new System.Drawing.Size(115, 23);
            this.findClosestStore.TabIndex = 9;
            this.findClosestStore.Text = "Find Closest Store";
            this.findClosestStore.UseVisualStyleBackColor = true;
            this.findClosestStore.Click += new System.EventHandler(this.FindClosestStore_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Closest Store Service";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(9, 168);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(471, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Given a zip code and store name returns the location of the nearest store";
            // 
            // storeName
            // 
            this.storeName.Location = new System.Drawing.Point(104, 187);
            this.storeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storeName.Name = "storeName";
            this.storeName.Size = new System.Drawing.Size(117, 20);
            this.storeName.TabIndex = 12;
            // 
            // zipCode
            // 
            this.zipCode.Location = new System.Drawing.Point(104, 213);
            this.zipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipCode.Name = "zipCode";
            this.zipCode.Size = new System.Drawing.Size(68, 20);
            this.zipCode.TabIndex = 13;
            // 
            // storeAddress
            // 
            this.storeAddress.Location = new System.Drawing.Point(104, 260);
            this.storeAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.storeAddress.Name = "storeAddress";
            this.storeAddress.Size = new System.Drawing.Size(220, 20);
            this.storeAddress.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 214);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Zip Code:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Store Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 262);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Store Address:";
            // 
            // ZipCodeBooking
            // 
            this.ZipCodeBooking.Location = new System.Drawing.Point(743, 57);
            this.ZipCodeBooking.Name = "ZipCodeBooking";
            this.ZipCodeBooking.Size = new System.Drawing.Size(193, 20);
            this.ZipCodeBooking.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(740, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Booking Service";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(740, 37);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(733, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Given a zipcode and an address returns nearby events and the driving time to the " +
    "event from the provided address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://i.imgur.com/FCmLeR0.png";
            this.pictureBox1.Location = new System.Drawing.Point(951, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 267);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(685, 60);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Zip Code:";
            // 
            // AddressBooking
            // 
            this.AddressBooking.Location = new System.Drawing.Point(743, 83);
            this.AddressBooking.Name = "AddressBooking";
            this.AddressBooking.Size = new System.Drawing.Size(193, 20);
            this.AddressBooking.TabIndex = 24;
            // 
            // touristInfo
            // 
            this.touristInfo.Location = new System.Drawing.Point(951, 348);
            this.touristInfo.Multiline = true;
            this.touristInfo.Name = "touristInfo";
            this.touristInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.touristInfo.Size = new System.Drawing.Size(802, 324);
            this.touristInfo.TabIndex = 25;
            // 
            // bookingService
            // 
            this.bookingService.Location = new System.Drawing.Point(743, 108);
            this.bookingService.Margin = new System.Windows.Forms.Padding(2);
            this.bookingService.Name = "bookingService";
            this.bookingService.Size = new System.Drawing.Size(157, 23);
            this.bookingService.TabIndex = 26;
            this.bookingService.Text = "Find Tourist Attractions";
            this.bookingService.UseVisualStyleBackColor = true;
            this.bookingService.Click += new System.EventHandler(this.BookingService_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(693, 83);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Address";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(882, 351);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 27;
            this.label15.Text = "Tourst Info: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 325);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "News Service";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.Location = new System.Drawing.Point(8, 338);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(359, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "Given a keyword returns news topics about the keyword";
            // 
            // keyword
            // 
            this.keyword.Location = new System.Drawing.Point(104, 367);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(193, 20);
            this.keyword.TabIndex = 30;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 367);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Keyword:";
            this.label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // newsResults
            // 
            this.newsResults.Location = new System.Drawing.Point(104, 420);
            this.newsResults.Multiline = true;
            this.newsResults.Name = "newsResults";
            this.newsResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.newsResults.Size = new System.Drawing.Size(621, 351);
            this.newsResults.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 392);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Find News Stories";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(30, 420);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 13);
            this.label19.TabIndex = 34;
            this.label19.Text = "News Stories:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 901);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newsResults);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bookingService);
            this.Controls.Add(this.touristInfo);
            this.Controls.Add(this.AddressBooking);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ZipCodeBooking);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.storeAddress);
            this.Controls.Add(this.zipCode);
            this.Controls.Add(this.storeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.findClosestStore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uvIndex);
            this.Controls.Add(this.latitude);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.longitude);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox longitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latitude;
        private System.Windows.Forms.TextBox uvIndex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findClosestStore;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox storeName;
        private System.Windows.Forms.TextBox zipCode;
        private System.Windows.Forms.TextBox storeAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ZipCodeBooking;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AddressBooking;
        private System.Windows.Forms.TextBox touristInfo;
        private System.Windows.Forms.Button bookingService;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox keyword;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox newsResults;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label19;
    }
}

