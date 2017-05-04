using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prototype
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }

        //Set Priority High
        private void label19_Click(object sender, EventArgs e)
        {
            // Check Focus when Priority High is pressed
            // Sunday
            if (sun1TextBox.Focused)
            {
                buttonSun1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun2TextBox.Focused)
            {
                buttonSun2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun3TextBox.Focused)
            {
                buttonSun3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun4TextBox.Focused)
            {
                buttonSun4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun5TextBox.Focused)
            {
                buttonSun5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun6TextBox.Focused)
            {
                buttonSun6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun7TextBox.Focused)
            {
                buttonSun7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun8TextBox.Focused)
            {
                buttonSun8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sun9TextBox.Focused)
            {
                buttonSun9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon1TextBox.Focused) // Start Monday
            {
                buttonMon1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon2TextBox.Focused)
            {
                buttonMon2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon3TextBox.Focused)
            {
                buttonMon3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon4TextBox.Focused)
            {
                buttonMon4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon5TextBox.Focused)
            {
                buttonMon5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon6TextBox.Focused)
            {
                buttonMon6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon7TextBox.Focused)
            {
                buttonMon7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon8TextBox.Focused)
            {
                buttonMon8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (mon9TextBox.Focused)
            {
                buttonMon9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue1TextBox.Focused) // Start Tuesday
            {
                buttonTue1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue2TextBox.Focused)
            {
                buttonTue2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue3TextBox.Focused)
            {
                buttonTue3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue4TextBox.Focused)
            {
                buttonTue4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue5TextBox.Focused)
            {
                buttonTue5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue6TextBox.Focused)
            {
                buttonTue6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue7TextBox.Focused)
            {
                buttonTue7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue8TextBox.Focused)
            {
                buttonTue8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (tue9TextBox.Focused)
            {
                buttonTue9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed1TextBox.Focused) // Start Wednesday
            {
                buttonWed1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed2TextBox.Focused)
            {
                buttonWed2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed3TextBox.Focused)
            {
                buttonWed3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed4TextBox.Focused)
            {
                buttonWed4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed5TextBox.Focused)
            {
                buttonWed5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed6TextBox.Focused)
            {
                buttonWed6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed7TextBox.Focused)
            {
                buttonWed7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed8TextBox.Focused)
            {
                buttonWed8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (wed9TextBox.Focused)
            {
                buttonWed9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu1TextBox.Focused) // Start Thursday
            {
                buttonThu1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu2TextBox.Focused)
            {
                buttonThu2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu3TextBox.Focused)
            {
                buttonThu3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu4TextBox.Focused)
            {
                buttonThu4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu5TextBox.Focused)
            {
                buttonThu5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu6TextBox.Focused)
            {
                buttonThu6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu7TextBox.Focused)
            {
                buttonThu7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu8TextBox.Focused)
            {
                buttonThu8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (thu9TextBox.Focused)
            {
                buttonThu9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri1TextBox.Focused) // Start Friday
            {
                buttonFri1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri2TextBox.Focused)
            {
                buttonFri2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri3TextBox.Focused)
            {
                buttonFri3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri4TextBox.Focused)
            {
                buttonFri4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri5TextBox.Focused)
            {
                buttonFri5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri6TextBox.Focused)
            {
                buttonFri6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri7TextBox.Focused)
            {
                buttonFri7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri8TextBox.Focused)
            {
                buttonFri8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (fri9TextBox.Focused)
            {
                buttonFri9.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat1TextBox.Focused) // Start Saturday
            {
                buttonSat1.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat2TextBox.Focused)
            {
                buttonSat2.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat3TextBox.Focused)
            {
                buttonSat3.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat4TextBox.Focused)
            {
                buttonSat4.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat5TextBox.Focused)
            {
                buttonSat5.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat6TextBox.Focused)
            {
                buttonSat6.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat7TextBox.Focused)
            {
                buttonSat7.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat8TextBox.Focused)
            {
                buttonSat8.BackColor = Color.FromArgb(255, 128, 128);
            }
            else if (sat9TextBox.Focused)
            {
                buttonSat9.BackColor = Color.FromArgb(255, 128, 128);
            }

        }

        //Set Priority Medium
        private void label20_Click(object sender, EventArgs e)
        {
            // Check Focus when Priority Medium is pressed
            // Sunday
            if (sun1TextBox.Focused)
            {
                buttonSun1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun2TextBox.Focused)
            {
                buttonSun2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun3TextBox.Focused)
            {
                buttonSun3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun4TextBox.Focused)
            {
                buttonSun4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun5TextBox.Focused)
            {
                buttonSun5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun6TextBox.Focused)
            {
                buttonSun6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun7TextBox.Focused)
            {
                buttonSun7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun8TextBox.Focused)
            {
                buttonSun8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sun9TextBox.Focused)
            {
                buttonSun9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon1TextBox.Focused) // Start Monday
            {
                buttonMon1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon2TextBox.Focused)
            {
                buttonMon2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon3TextBox.Focused)
            {
                buttonMon3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon4TextBox.Focused)
            {
                buttonMon4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon5TextBox.Focused)
            {
                buttonMon5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon6TextBox.Focused)
            {
                buttonMon6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon7TextBox.Focused)
            {
                buttonMon7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon8TextBox.Focused)
            {
                buttonMon8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (mon9TextBox.Focused)
            {
                buttonMon9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue1TextBox.Focused) // Start Tuesday
            {
                buttonTue1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue2TextBox.Focused)
            {
                buttonTue2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue3TextBox.Focused)
            {
                buttonTue3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue4TextBox.Focused)
            {
                buttonTue4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue5TextBox.Focused)
            {
                buttonTue5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue6TextBox.Focused)
            {
                buttonTue6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue7TextBox.Focused)
            {
                buttonTue7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue8TextBox.Focused)
            {
                buttonTue8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (tue9TextBox.Focused)
            {
                buttonTue9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed1TextBox.Focused) // Start Wednesday
            {
                buttonWed1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed2TextBox.Focused)
            {
                buttonWed2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed3TextBox.Focused)
            {
                buttonWed3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed4TextBox.Focused)
            {
                buttonWed4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed5TextBox.Focused)
            {
                buttonWed5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed6TextBox.Focused)
            {
                buttonWed6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed7TextBox.Focused)
            {
                buttonWed7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed8TextBox.Focused)
            {
                buttonWed8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (wed9TextBox.Focused)
            {
                buttonWed9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu1TextBox.Focused) // Start Thursday
            {
                buttonThu1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu2TextBox.Focused)
            {
                buttonThu2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu3TextBox.Focused)
            {
                buttonThu3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu4TextBox.Focused)
            {
                buttonThu4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu5TextBox.Focused)
            {
                buttonThu5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu6TextBox.Focused)
            {
                buttonThu6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu7TextBox.Focused)
            {
                buttonThu7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu8TextBox.Focused)
            {
                buttonThu8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (thu9TextBox.Focused)
            {
                buttonThu9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri1TextBox.Focused) // Start Friday
            {
                buttonFri1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri2TextBox.Focused)
            {
                buttonFri2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri3TextBox.Focused)
            {
                buttonFri3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri4TextBox.Focused)
            {
                buttonFri4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri5TextBox.Focused)
            {
                buttonFri5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri6TextBox.Focused)
            {
                buttonFri6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri7TextBox.Focused)
            {
                buttonFri7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri8TextBox.Focused)
            {
                buttonFri8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (fri9TextBox.Focused)
            {
                buttonFri9.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat1TextBox.Focused) // Start Saturday
            {
                buttonSat1.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat2TextBox.Focused)
            {
                buttonSat2.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat3TextBox.Focused)
            {
                buttonSat3.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat4TextBox.Focused)
            {
                buttonSat4.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat5TextBox.Focused)
            {
                buttonSat5.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat6TextBox.Focused)
            {
                buttonSat6.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat7TextBox.Focused)
            {
                buttonSat7.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat8TextBox.Focused)
            {
                buttonSat8.BackColor = Color.FromArgb(255, 192, 128);
            }
            else if (sat9TextBox.Focused)
            {
                buttonSat9.BackColor = Color.FromArgb(255, 192, 128);
            }

        }

        //Set Priority Low
        private void label21_Click(object sender, EventArgs e)
        {
            // Check Focus when Priority Low is pressed
            // Sunday
            if (sun1TextBox.Focused)
            {
                buttonSun1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun2TextBox.Focused)
            {
                buttonSun2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun3TextBox.Focused)
            {
                buttonSun3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun4TextBox.Focused)
            {
                buttonSun4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun5TextBox.Focused)
            {
                buttonSun5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun6TextBox.Focused)
            {
                buttonSun6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun7TextBox.Focused)
            {
                buttonSun7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun8TextBox.Focused)
            {
                buttonSun8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sun9TextBox.Focused)
            {
                buttonSun9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon1TextBox.Focused) // Start Monday
            {
                buttonMon1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon2TextBox.Focused)
            {
                buttonMon2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon3TextBox.Focused)
            {
                buttonMon3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon4TextBox.Focused)
            {
                buttonMon4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon5TextBox.Focused)
            {
                buttonMon5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon6TextBox.Focused)
            {
                buttonMon6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon7TextBox.Focused)
            {
                buttonMon7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon8TextBox.Focused)
            {
                buttonMon8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (mon9TextBox.Focused)
            {
                buttonMon9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue1TextBox.Focused) // Start Tuesday
            {
                buttonTue1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue2TextBox.Focused)
            {
                buttonTue2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue3TextBox.Focused)
            {
                buttonTue3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue4TextBox.Focused)
            {
                buttonTue4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue5TextBox.Focused)
            {
                buttonTue5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue6TextBox.Focused)
            {
                buttonTue6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue7TextBox.Focused)
            {
                buttonTue7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue8TextBox.Focused)
            {
                buttonTue8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (tue9TextBox.Focused)
            {
                buttonTue9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed1TextBox.Focused) // Start Wednesday
            {
                buttonWed1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed2TextBox.Focused)
            {
                buttonWed2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed3TextBox.Focused)
            {
                buttonWed3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed4TextBox.Focused)
            {
                buttonWed4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed5TextBox.Focused)
            {
                buttonWed5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed6TextBox.Focused)
            {
                buttonWed6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed7TextBox.Focused)
            {
                buttonWed7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed8TextBox.Focused)
            {
                buttonWed8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (wed9TextBox.Focused)
            {
                buttonWed9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu1TextBox.Focused) // Start Thursday
            {
                buttonThu1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu2TextBox.Focused)
            {
                buttonThu2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu3TextBox.Focused)
            {
                buttonThu3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu4TextBox.Focused)
            {
                buttonThu4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu5TextBox.Focused)
            {
                buttonThu5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu6TextBox.Focused)
            {
                buttonThu6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu7TextBox.Focused)
            {
                buttonThu7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu8TextBox.Focused)
            {
                buttonThu8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (thu9TextBox.Focused)
            {
                buttonThu9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri1TextBox.Focused) // Start Friday
            {
                buttonFri1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri2TextBox.Focused)
            {
                buttonFri2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri3TextBox.Focused)
            {
                buttonFri3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri4TextBox.Focused)
            {
                buttonFri4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri5TextBox.Focused)
            {
                buttonFri5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri6TextBox.Focused)
            {
                buttonFri6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri7TextBox.Focused)
            {
                buttonFri7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri8TextBox.Focused)
            {
                buttonFri8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (fri9TextBox.Focused)
            {
                buttonFri9.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat1TextBox.Focused) // Start Saturday
            {
                buttonSat1.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat2TextBox.Focused)
            {
                buttonSat2.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat3TextBox.Focused)
            {
                buttonSat3.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat4TextBox.Focused)
            {
                buttonSat4.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat5TextBox.Focused)
            {
                buttonSat5.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat6TextBox.Focused)
            {
                buttonSat6.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat7TextBox.Focused)
            {
                buttonSat7.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat8TextBox.Focused)
            {
                buttonSat8.BackColor = Color.FromArgb(128, 255, 255);
            }
            else if (sat9TextBox.Focused)
            {
                buttonSat9.BackColor = Color.FromArgb(128, 255, 255);
            }
        }

        //Set Priority Completed
        private void label22_Click(object sender, EventArgs e)
        {
            // Check Focus when Priority Low is pressed
            // Sunday
            if (sun1TextBox.Focused)
            {
                buttonSun1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun2TextBox.Focused)
            {
                buttonSun2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun3TextBox.Focused)
            {
                buttonSun3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun4TextBox.Focused)
            {
                buttonSun4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun5TextBox.Focused)
            {
                buttonSun5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun6TextBox.Focused)
            {
                buttonSun6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun7TextBox.Focused)
            {
                buttonSun7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun8TextBox.Focused)
            {
                buttonSun8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sun9TextBox.Focused)
            {
                buttonSun9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon1TextBox.Focused) // Start Monday
            {
                buttonMon1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon2TextBox.Focused)
            {
                buttonMon2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon3TextBox.Focused)
            {
                buttonMon3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon4TextBox.Focused)
            {
                buttonMon4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon5TextBox.Focused)
            {
                buttonMon5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon6TextBox.Focused)
            {
                buttonMon6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon7TextBox.Focused)
            {
                buttonMon7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon8TextBox.Focused)
            {
                buttonMon8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (mon9TextBox.Focused)
            {
                buttonMon9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue1TextBox.Focused) // Start Tuesday
            {
                buttonTue1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue2TextBox.Focused)
            {
                buttonTue2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue3TextBox.Focused)
            {
                buttonTue3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue4TextBox.Focused)
            {
                buttonTue4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue5TextBox.Focused)
            {
                buttonTue5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue6TextBox.Focused)
            {
                buttonTue6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue7TextBox.Focused)
            {
                buttonTue7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue8TextBox.Focused)
            {
                buttonTue8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (tue9TextBox.Focused)
            {
                buttonTue9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed1TextBox.Focused) // Start Wednesday
            {
                buttonWed1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed2TextBox.Focused)
            {
                buttonWed2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed3TextBox.Focused)
            {
                buttonWed3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed4TextBox.Focused)
            {
                buttonWed4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed5TextBox.Focused)
            {
                buttonWed5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed6TextBox.Focused)
            {
                buttonWed6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed7TextBox.Focused)
            {
                buttonWed7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed8TextBox.Focused)
            {
                buttonWed8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (wed9TextBox.Focused)
            {
                buttonWed9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu1TextBox.Focused) // Start Thursday
            {
                buttonThu1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu2TextBox.Focused)
            {
                buttonThu2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu3TextBox.Focused)
            {
                buttonThu3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu4TextBox.Focused)
            {
                buttonThu4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu5TextBox.Focused)
            {
                buttonThu5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu6TextBox.Focused)
            {
                buttonThu6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu7TextBox.Focused)
            {
                buttonThu7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu8TextBox.Focused)
            {
                buttonThu8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (thu9TextBox.Focused)
            {
                buttonThu9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri1TextBox.Focused) // Start Friday
            {
                buttonFri1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri2TextBox.Focused)
            {
                buttonFri2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri3TextBox.Focused)
            {
                buttonFri3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri4TextBox.Focused)
            {
                buttonFri4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri5TextBox.Focused)
            {
                buttonFri5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri6TextBox.Focused)
            {
                buttonFri6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri7TextBox.Focused)
            {
                buttonFri7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri8TextBox.Focused)
            {
                buttonFri8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (fri9TextBox.Focused)
            {
                buttonFri9.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat1TextBox.Focused) // Start Saturday
            {
                buttonSat1.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat2TextBox.Focused)
            {
                buttonSat2.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat3TextBox.Focused)
            {
                buttonSat3.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat4TextBox.Focused)
            {
                buttonSat4.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat5TextBox.Focused)
            {
                buttonSat5.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat6TextBox.Focused)
            {
                buttonSat6.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat7TextBox.Focused)
            {
                buttonSat7.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat8TextBox.Focused)
            {
                buttonSat8.BackColor = Color.FromArgb(128, 255, 128);
            }
            else if (sat9TextBox.Focused)
            {
                buttonSat9.BackColor = Color.FromArgb(128, 255, 128);
            }
        }

        //Start Priority Clear

        private void buttonSun1_Click(object sender, EventArgs e)
        {
            buttonSun1.BackColor = Color.White;
        }

        private void buttonSun2_Click(object sender, EventArgs e)
        {
            buttonSun2.BackColor = Color.White;
        }

        private void buttonSun3_Click(object sender, EventArgs e)
        {
            buttonSun3.BackColor = Color.White;
        }

        private void buttonSun4_Click(object sender, EventArgs e)
        {
            buttonSun4.BackColor = Color.White;
        }

        private void buttonSun5_Click(object sender, EventArgs e)
        {
            buttonSun5.BackColor = Color.White;
        }

        private void buttonSun6_Click(object sender, EventArgs e)
        {
            buttonSun6.BackColor = Color.White;
        }

        private void buttonSun7_Click(object sender, EventArgs e)
        {
            buttonSun7.BackColor = Color.White;
        }

        private void buttonSun8_Click(object sender, EventArgs e)
        {
            buttonSun8.BackColor = Color.White;
        }

        private void buttonSun9_Click(object sender, EventArgs e)
        {
            buttonSun9.BackColor = Color.White;
        }

        private void buttonMon1_Click(object sender, EventArgs e)
        {
            buttonMon1.BackColor = Color.White;
        }

        private void buttonMon2_Click(object sender, EventArgs e)
        {
            buttonMon2.BackColor = Color.White;
        }

        private void buttonMon3_Click(object sender, EventArgs e)
        {
            buttonMon3.BackColor = Color.White;
        }

        private void buttonMon4_Click(object sender, EventArgs e)
        {
            buttonMon4.BackColor = Color.White;
        }

        private void buttonMon5_Click(object sender, EventArgs e)
        {
            buttonMon5.BackColor = Color.White;
        }

        private void buttonMon6_Click(object sender, EventArgs e)
        {
            buttonMon6.BackColor = Color.White;
        }

        private void buttonMon7_Click(object sender, EventArgs e)
        {
            buttonMon7.BackColor = Color.White;
        }

        private void buttonMon8_Click(object sender, EventArgs e)
        {
            buttonMon8.BackColor = Color.White;
        }

        private void buttonMon9_Click(object sender, EventArgs e)
        {
            buttonMon9.BackColor = Color.White;
        }

        private void buttonTue1_Click(object sender, EventArgs e)
        {
            buttonTue1.BackColor = Color.White;
        }

        private void buttonTue2_Click(object sender, EventArgs e)
        {
            buttonTue2.BackColor = Color.White;
        }

        private void buttonTue3_Click(object sender, EventArgs e)
        {
            buttonTue3.BackColor = Color.White;
        }

        private void buttonTue4_Click(object sender, EventArgs e)
        {
            buttonTue4.BackColor = Color.White;
        }

        private void buttonTue5_Click(object sender, EventArgs e)
        {
            buttonTue5.BackColor = Color.White;
        }

        private void buttonTue6_Click(object sender, EventArgs e)
        {
            buttonTue6.BackColor = Color.White;
        }

        private void buttonTue7_Click(object sender, EventArgs e)
        {
            buttonTue7.BackColor = Color.White;
        }

        private void buttonTue8_Click(object sender, EventArgs e)
        {
            buttonTue8.BackColor = Color.White;
        }

        private void buttonTue9_Click(object sender, EventArgs e)
        {
            buttonTue9.BackColor = Color.White;
        }

        private void buttonWed1_Click(object sender, EventArgs e)
        {
            buttonWed1.BackColor = Color.White;
        }

        private void buttonWed2_Click(object sender, EventArgs e)
        {
            buttonWed2.BackColor = Color.White;
        }

        private void buttonWed3_Click(object sender, EventArgs e)
        {
            buttonWed3.BackColor = Color.White;
        }

        private void buttonWed4_Click(object sender, EventArgs e)
        {
            buttonWed4.BackColor = Color.White;
        }

        private void buttonWed5_Click(object sender, EventArgs e)
        {
            buttonWed5.BackColor = Color.White;
        }

        private void buttonWed6_Click(object sender, EventArgs e)
        {
            buttonWed6.BackColor = Color.White;
        }

        private void buttonWed7_Click(object sender, EventArgs e)
        {
            buttonWed7.BackColor = Color.White;
        }

        private void buttonWed8_Click(object sender, EventArgs e)
        {
            buttonWed8.BackColor = Color.White;
        }

        private void buttonWed9_Click(object sender, EventArgs e)
        {
            buttonWed9.BackColor = Color.White;
        }

        private void buttonThu1_Click(object sender, EventArgs e)
        {
            buttonThu1.BackColor = Color.White;
        }

        private void buttonThu2_Click(object sender, EventArgs e)
        {
            buttonThu2.BackColor = Color.White;
        }

        private void buttonThu3_Click(object sender, EventArgs e)
        {
            buttonThu3.BackColor = Color.White;
        }

        private void buttonThu4_Click(object sender, EventArgs e)
        {
            buttonThu4.BackColor = Color.White;
        }

        private void buttonThu5_Click(object sender, EventArgs e)
        {
            buttonThu5.BackColor = Color.White;
        }

        private void buttonThu6_Click(object sender, EventArgs e)
        {
            buttonThu6.BackColor = Color.White;
        }

        private void buttonThu7_Click(object sender, EventArgs e)
        {
            buttonThu7.BackColor = Color.White;
        }

        private void buttonThu8_Click(object sender, EventArgs e)
        {
            buttonThu8.BackColor = Color.White;
        }

        private void buttonThu9_Click(object sender, EventArgs e)
        {
            buttonThu9.BackColor = Color.White;
        }

        private void buttonFri1_Click(object sender, EventArgs e)
        {
            buttonFri1.BackColor = Color.White;
        }

        private void buttonFri2_Click(object sender, EventArgs e)
        {
            buttonFri2.BackColor = Color.White;
        }

        private void buttonFri3_Click(object sender, EventArgs e)
        {
            buttonFri3.BackColor = Color.White;
        }

        private void buttonFri4_Click(object sender, EventArgs e)
        {
            buttonFri4.BackColor = Color.White;
        }

        private void buttonFri5_Click(object sender, EventArgs e)
        {
            buttonFri5.BackColor = Color.White;
        }

        private void buttonFri6_Click(object sender, EventArgs e)
        {
            buttonFri6.BackColor = Color.White;
        }

        private void buttonFri7_Click(object sender, EventArgs e)
        {
            buttonFri7.BackColor = Color.White;
        }

        private void buttonFri8_Click(object sender, EventArgs e)
        {
            buttonFri8.BackColor = Color.White;
        }

        private void buttonFri9_Click(object sender, EventArgs e)
        {
            buttonFri9.BackColor = Color.White;
        }

        private void buttonSat1_Click(object sender, EventArgs e)
        {
            buttonSat1.BackColor = Color.White;
        }

        private void buttonSat2_Click(object sender, EventArgs e)
        {
            buttonSat2.BackColor = Color.White;
        }

        private void buttonSat3_Click(object sender, EventArgs e)
        {
            buttonSat3.BackColor = Color.White;
        }

        private void buttonSat4_Click(object sender, EventArgs e)
        {
            buttonSat4.BackColor = Color.White;
        }

        private void buttonSat5_Click(object sender, EventArgs e)
        {
            buttonSat5.BackColor = Color.White;
        }

        private void buttonSat6_Click(object sender, EventArgs e)
        {
            buttonSat6.BackColor = Color.White;
        }

        private void buttonSat7_Click(object sender, EventArgs e)
        {
            buttonSat7.BackColor = Color.White;
        }

        private void buttonSat8_Click(object sender, EventArgs e)
        {
            buttonSat8.BackColor = Color.White;
        }

        private void buttonSat9_Click(object sender, EventArgs e)
        {
            buttonSat9.BackColor = Color.White;
        }
        //End Individual Priority Clear

        //Clear All Priotities
        private void button1_Click(object sender, EventArgs e)
        {
            buttonSun1.BackColor = Color.White;
            buttonSun2.BackColor = Color.White;
            buttonSun3.BackColor = Color.White;
            buttonSun4.BackColor = Color.White;
            buttonSun5.BackColor = Color.White;
            buttonSun6.BackColor = Color.White;
            buttonSun7.BackColor = Color.White;
            buttonSun8.BackColor = Color.White;
            buttonSun9.BackColor = Color.White;

            buttonMon1.BackColor = Color.White;
            buttonMon2.BackColor = Color.White;
            buttonMon3.BackColor = Color.White;
            buttonMon4.BackColor = Color.White;
            buttonMon5.BackColor = Color.White;
            buttonMon6.BackColor = Color.White;
            buttonMon7.BackColor = Color.White;
            buttonMon8.BackColor = Color.White;
            buttonMon9.BackColor = Color.White;

            buttonTue1.BackColor = Color.White;
            buttonTue2.BackColor = Color.White;
            buttonTue3.BackColor = Color.White;
            buttonTue4.BackColor = Color.White;
            buttonTue5.BackColor = Color.White;
            buttonTue6.BackColor = Color.White;
            buttonTue7.BackColor = Color.White;
            buttonTue8.BackColor = Color.White;
            buttonTue9.BackColor = Color.White;

            buttonWed1.BackColor = Color.White;
            buttonWed2.BackColor = Color.White;
            buttonWed3.BackColor = Color.White;
            buttonWed4.BackColor = Color.White;
            buttonWed5.BackColor = Color.White;
            buttonWed6.BackColor = Color.White;
            buttonWed7.BackColor = Color.White;
            buttonWed8.BackColor = Color.White;
            buttonWed9.BackColor = Color.White;

            buttonThu1.BackColor = Color.White;
            buttonThu2.BackColor = Color.White;
            buttonThu3.BackColor = Color.White;
            buttonThu4.BackColor = Color.White;
            buttonThu5.BackColor = Color.White;
            buttonThu6.BackColor = Color.White;
            buttonThu7.BackColor = Color.White;
            buttonThu8.BackColor = Color.White;
            buttonThu9.BackColor = Color.White;

            buttonFri1.BackColor = Color.White;
            buttonFri2.BackColor = Color.White;
            buttonFri3.BackColor = Color.White;
            buttonFri4.BackColor = Color.White;
            buttonFri5.BackColor = Color.White;
            buttonFri6.BackColor = Color.White;
            buttonFri7.BackColor = Color.White;
            buttonFri8.BackColor = Color.White;
            buttonFri9.BackColor = Color.White;

            buttonSat1.BackColor = Color.White;
            buttonSat2.BackColor = Color.White;
            buttonSat3.BackColor = Color.White;
            buttonSat4.BackColor = Color.White;
            buttonSat5.BackColor = Color.White;
            buttonSat6.BackColor = Color.White;
            buttonSat7.BackColor = Color.White;
            buttonSat8.BackColor = Color.White;
            buttonSat9.BackColor = Color.White;

        }

        private void sun1TextBox_DoubleClick(object sender, EventArgs e)
        {

             MessageBox.Show("This is for Long Text Box", "Long Text Box",
                MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Saved",
                 MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

