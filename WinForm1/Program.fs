open System.Drawing
open System.Windows.Forms
open System

// Create main form window
let mainForm = new Form(Width = 620, Height = 450, Text = "Pie Chart")
// Create the menu with two items (Open and Save)
let menu = new ToolStrip()
let btnOpen = new ToolStripButton("Open")
let btnSave = new ToolStripButton("Save", Enabled = false)

ignore (menu.Items.Add(btnOpen))
ignore (menu.Items.Add(btnSave))
mainForm.Controls.Add(menu)

// Create picture box for displaying the chart
let boxChart = new PictureBox(BackColor = Color.White, Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.CenterImage)

mainForm.Controls.Add(boxChart)

// Listing 4.7 Creating a brush with random colors
let rnd = new Random()

// Returns a brush of random color (generated using a 
// global 'rnd'). Calling 'rnd.Next' has side effects
let randomBrush() = 
    let r, g, b = rnd.Next(256), rnd.Next(256), rnd.Next(256)
    new SolidBrush(Color.FromArgb(r, g, b))

// Entry-point for the graphical version   
[<STAThread>]
do // Specify event handlers - a function called when button is clicked
   //btnOpen.Click.Add(openAndDrawChart)
   //btnSave.Click.Add(saveDrawing)
   Application.EnableVisualStyles()
   Application.Run(mainForm)
