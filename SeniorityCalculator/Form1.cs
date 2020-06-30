using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeniorityCalculator
{
	
	public partial class Form1 : Form
	{
		private List<Panel> panels;
		public Form1()
		{
			InitializeComponent();
			panels = new List<Panel>();
			Panel panel = CreateNewPanel(1, 0);
			panels.Add(panel);
			mainPanel.Controls.Add(panel);
		}

		private Panel CreateNewPanel(int num, int Y) 
		{
			Panel panel = new Panel();
			panel.Location = new Point(10, Y + 40);
			panel.Size = new Size(470, 40);

			DateTimePicker startDTP = new DateTimePicker();
			startDTP.Location = new Point(25, 5);
			startDTP.Name = "startDTP";
			startDTP.Size = new Size(130,29);
			startDTP.Font = new Font("Palatino Linotype", 12);
			startDTP.Format = DateTimePickerFormat.Short;
			panel.Controls.Add(startDTP);

			DateTimePicker endDTP = new DateTimePicker();
			endDTP.Location = new Point(228, 5);
			endDTP.Name = "endDTP";
			endDTP.Size = new Size(130, 29);
			endDTP.Font = new Font("Palatino Linotype", 12);
			endDTP.Format = DateTimePickerFormat.Short;
			panel.Controls.Add(endDTP);

			Button deleteButton = new Button();
			deleteButton.Location = new Point(398, 5);
			deleteButton.Size = new Size(32, 29);
			deleteButton.Text = "";
			deleteButton.Image = Properties.Resources.redXmark;
			deleteButton.Click += deleteButton_Click;
			panel.Controls.Add(deleteButton);

			return panel;
		}
		private void Repaint() 
		{
			foreach (var panel in panels) 
			{
				mainPanel.Controls.Remove(panel);
			}
			panels.ElementAt(0).Location = new Point(10, 40);
			for (int i = 1; i < panels.Count; i++) 
			{
				int Y = panels.ElementAt(i - 1).Location.Y;
				panels.ElementAt(i).Location = new Point(10, (i+1)*40);
			}
			foreach (var panel in panels)
			{
				mainPanel.Controls.Add(panel);
			}
		}
		private bool CanConcat(DateInterval interval1, DateInterval interval2) 
		{
			if (interval1.start <= interval2.start && interval2.start <= interval1.end)
			{
				return true;
			}
			else 
			{
				return false;
			}
		}
		private TimeSpan SumOfIntervals(List<DateInterval> intervals) 
		{
            intervals.Sort();
			for (int i = 0; i < intervals.Count - 1; ) 
			{
				if (CanConcat(intervals.ElementAt(i), intervals.ElementAt(i + 1)))
				{
					if (intervals.ElementAt(i).end < intervals.ElementAt(i + 1).end) 
					{
						intervals.ElementAt(i).end = intervals.ElementAt(i + 1).end;
					} 
					intervals.RemoveAt(i + 1);
				}
				else 
				{
					i++;
				}
			}
			TimeSpan result = new TimeSpan();
			foreach (var interval in intervals) 
			{
				result += interval.end.AddDays(1) - interval.start;
			}
            return result;
		}
		private TimeSpan MilitaryResult() 
		{
			switch (regularMilitaryComboBox.SelectedIndex) 
			{
				case 1:
					return new TimeSpan(730, 12, 0, 0);
				case 2:
					return new TimeSpan(1095, 18, 0, 0);
				case 3:
					return new TimeSpan(1461, 0, 0, 0);
				default:
					return new TimeSpan(0);
			}
		}
		private TimeSpan ParentalLeaveResult()
		{
			switch (parentalLeaveComboBox.SelectedIndex)
			{
				case 1:
					return new TimeSpan(546, 21, 0, 0);
				case 2:
					return new TimeSpan(1095, 18, 0, 0);
				case 3:
					return new TimeSpan(1642, 15, 0, 0);
				default:
					return new TimeSpan(0);
			}
		}


		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			Panel panel = CreateNewPanel(panels.Count + 1, panels.ElementAt(panels.Count - 1).Location.Y);
			panels.Add(panel);
			mainPanel.Controls.Add(panel);
		}
		private void deleteButton_Click(object sender, EventArgs e)
		{
			if (panels.Count == 1) 
			{
				MessageBox.Show("Должен быть минимум один срок работы");
				return;
			}
			foreach (var panel in panels) 
			{
				if(panel.Controls.Contains((Button)sender))
				{
					mainPanel.Controls.Remove(panel);
					panels.Remove(panel);
					Repaint();
					break;
				}
			}
		}
        private void clearButton_Click(object sender, EventArgs e)
        {
			foreach (var item in panels) 
			{
				mainPanel.Controls.Remove(item);
			}
			panels.Clear();
			Panel panel = CreateNewPanel(1, 0);
			panels.Add(panel);
			mainPanel.Controls.Add(panel);
			regularMilitaryComboBox.SelectedItem = "Нет";
			parentalLeaveComboBox.SelectedItem = "Нет";
			calculatedResult.Text = "";
		}
        private void calculateButton_Click(object sender, EventArgs e)
        {
			List<DateInterval> ListOfIntervals = new List<DateInterval>(); 
			int i = 0;
			foreach (var panel in panels) 
			{
				DateInterval buf = new DateInterval();
				buf.start = ((DateTimePicker)panel.Controls.Find("startDTP", false).ElementAt(0)).Value;
				buf.end = ((DateTimePicker)panel.Controls.Find("endDTP", false).ElementAt(0)).Value;
				if (buf.end < buf.start) 
				{
					MessageBox.Show("Дата приема на работу не может быть позже даты увольнения\nПроверьте правильность заполнения данных");
					break;
				}
				ListOfIntervals.Add(buf);
				i++;
			}
			TimeSpan result = SumOfIntervals(ListOfIntervals);
			result += MilitaryResult();
			result += ParentalLeaveResult();
			int days = -1, months = -1, years = -1;
			DateTime date = new DateTime(result.Ticks);
			days += date.Day;
			months += date.Month;
			years += date.Year;
			calculatedResult.Text = "";
			calculatedResult.Text += years.ToString() + " г. ";
			calculatedResult.Text += months.ToString() + " м. ";
			calculatedResult.Text += days.ToString() + " д. ";
        }
    }
}
