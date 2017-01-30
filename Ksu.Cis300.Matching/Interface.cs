using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
/*
 * Author <Harris Schrick>
 * 
 */

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Matching
{
    public partial class ParenthesisMatcher : Form
    {
        public ParenthesisMatcher()
        {
            InitializeComponent();
        }

        /// <summary>
        /// checks if parenthesis match
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCheck_Click(object sender, EventArgs e)
        {
            string test = uxTextBox.Text;
            Stack<char> s = new Stack<char>();

            foreach (char c in test)
            {
                //opening bracket
                if (c == '(' ||c == '{'||c == '[')
                {
                    s.Push(c);
                }
                //closing bracket
                if (c == ')' || c == '}' || c == ']')
                {
                    if (s.Count > 0 && Matches(s.Peek(),c))
                    {
                        s.Pop();
                    }
                    else
                    {
                        ShowError();
                        return;

                    }
                }




            }
            if(s.Count == 0)
            {
                ShowSuccess();
            }
            else
            {
                ShowError();
            }
        }



        /// <summary>
        /// Determines whether the given character is an opening parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is an opening parenthesis.</returns>
        private bool IsOpeningParenthesis(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        /// <summary>
        /// Determines whether the given character is a closing parenthesis.
        /// </summary>
        /// <param name="c">The character to check.</param>
        /// <returns>Whether c is a closing parenthesis.</returns>
        private bool IsClosingParenthesis(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }

        /// <summary>
        /// Determines whether the given characters for a matched pair
        /// of parentheses.
        /// </summary>
        /// <param name="a">The opening character.</param>
        /// <param name="b">The closing character.</param>
        /// <returns>Whether a and b form a matched pair of parentheses.</returns>
        private bool Matches(char a, char b)
        {
            return (a == '(' && b == ')') || (a == '[' && b == ']') ||
                (a == '{' && b == '}');
        }

        /// <summary>
        /// Displays a success message.
        /// </summary>
        private void ShowSuccess()
        {
            MessageBox.Show("The string is matched.");
        }

        /// <summary>
        /// Displays an error message.
        /// </summary>
        private void ShowError()
        {
            MessageBox.Show("The string is not matched.");
        }

        private void ParenthesisMatcher_Load(object sender, EventArgs e)
        {

        }
    }
}
