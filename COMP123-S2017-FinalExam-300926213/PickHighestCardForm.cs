using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:
 * Date:
 * StudentID:
 * Description:
 * Version:
 */

namespace COMP123_S2017_FinalExam_300926213
{
    public partial class PickHighestCardForm : Form
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        List<PictureBox> _dealtCardPictureBoxList;
        int _currentDealtCardIndex;
        PictureBox _currentClickedCard;
        Deck _deck;
        Hand _hand;
        int _maximumPoints;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<PictureBox> DealtCardPictureBoxList
        {
            get
            {
                return this._dealtCardPictureBoxList;
            }

            set
            {
                this._dealtCardPictureBoxList = value;
            }
        }

        public int CurrentDealtCardIndex
        {

            get
            {
                return this._currentDealtCardIndex;
            }

            set
            {
                this._currentDealtCardIndex = value;
            }
        }

        public Deck Deck
        {

            get
            {
                return this._deck;
            }

            set
            {
                this._deck = value;
            }
        }

        public Hand Hand
        {
            get
            {
                return this._hand;
            }

            set
            {
                this._hand = value;
            }
        }

        public PictureBox CurrentClickedCard
        {

            get
            {
                return this._currentClickedCard;
            }

            set
            {
                this._currentClickedCard = value;
            }
        }

        public int MaximumPoints
        {
            get
            {
                return this._maximumPoints;
            }

            set
            {
                this._maximumPoints = value;
            }
        }

        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public PickHighestCardForm()
        {
            InitializeComponent();
        }

        // PRIVATE METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        /// <summary>
        /// This is the DealButton's "Click" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DealButton_Click(object sender, EventArgs e)
        {
            this._hideCards();
            this._resetDeck();
            CardShowTimer.Enabled = true;
            UserMessageTextBox.Text = "Pick the Highest Card";
            DealButton.Enabled = false;
            this.MaximumPoints = 100;
        }

        /// <summary>
        /// This method displays each of the Dealt Cards
        /// </summary>
        private void _displayDealtCards()
        {
            PictureBox CurrentDealtCard = this.DealtCardPictureBoxList[this.CurrentDealtCardIndex];
            CurrentDealtCard.Visible = true;
            this.CurrentDealtCardIndex = this.DealtCardPictureBoxList.IndexOf(CurrentDealtCard) + 1;
            if (this.CurrentDealtCardIndex >= this.DealtCardPictureBoxList.Count)
            {
                CardShowTimer.Enabled = false;
            }
        }

        /// <summary>
        /// This is the CardTimer's "Tick" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardTimer_Tick(object sender, EventArgs e)
        {
            this._displayDealtCards();

        }

        /// <summary>
        /// This method hides the card picture boxes and
        /// resets their BackColor properties to black
        /// </summary>
        private void _hideCards()
        {
            // Set the Visible Property of each DealtCardPictureBox to False
            foreach (var dealtCard in DealtCardPictureBoxList)
            {
                dealtCard.Image = Properties.Resources.cardback;
                dealtCard.BackColor = Color.Black;
                dealtCard.Visible = false;
            }
            this.CurrentDealtCardIndex = 0;
        }

        /// <summary>
        /// This method resets the Deck, shuffles it and deals a hand of five cards
        /// </summary>
        private void _resetDeck()
        {
            // Initialize the Deck and Hand objects
            this.Deck = new Deck();
            this.Deck.Shuffle();
            this.Hand = this.Deck.Deal5();
        }

        /// <summary>
        /// This method resets the game
        /// </summary>
        private void _reset()
        {
            this._hideCards();
            this._resetDeck();
            CountDownTimer.Enabled = true;
            this.MaximumPoints = 100;
            DealButton.Enabled = true;
            this._enableDealtCards();
            this._hideFinalScore();
            UserMessageTextBox.Text = "Click the Deal Button!";
        }

        /// <summary>
        /// This method builds the DealtCardPictureBoxList
        /// </summary>
        private void _buildDealtCardPictureBoxList()
        {
            this.DealtCardPictureBoxList = new List<PictureBox>();
            this.DealtCardPictureBoxList.Add(FirstCardPictureBox);
            this.DealtCardPictureBoxList.Add(SecondCardPictureBox);
            this.DealtCardPictureBoxList.Add(ThirdCardPictureBox);
            this.DealtCardPictureBoxList.Add(FourthCardPictureBox);
            this.DealtCardPictureBoxList.Add(FifthCardPictureBox);
        }

        /// <summary>
        /// This is the Form's "Load" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PickHighestCardForm_Load(object sender, EventArgs e)
        {
            // Initialize ScoreBoard HERE

            // Initialize the App Sounds
            this._buildDealtCardPictureBoxList();
            this._reset();
        }

        /// <summary>
        /// This is the ResetButton's "Click" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            this._reset();
        }

        /// <summary>
        /// This method sets the image of the Clicked Picture box
        /// </summary>
        private void _cardPictureBoxSetImage()
        {
            // get the index of the PictureBox in the DealtCardPictureBoxList
            int pictureBoxIndex = DealtCardPictureBoxList.IndexOf(this.CurrentClickedCard);

            // convert each card in the Hand object to a string
            string cardstring = this.Hand[pictureBoxIndex].Face.ToString().ToLower();
            cardstring += this.Hand[pictureBoxIndex].Suit.ToString().ToLower();

            Debug.WriteLine(cardstring);

            // use the cardstring to select the appropriate image
            Image cardImage = Properties.Resources.ResourceManager.GetObject(cardstring) as Image;
            // set the image of the current CardPictureBox to the cardimage
            this.CurrentClickedCard.Image = cardImage;
        }

        /// <summary>
        /// This method shows different user messages based on where the highest card is in the Hand
        /// </summary>
        private void _showUserMessage()
        {
            // get the index of the PictureBox in the DealtCardPictureBoxList
            int pictureBoxIndex = DealtCardPictureBoxList.IndexOf(this.CurrentClickedCard);

            // If the highest card is selected then change background to Green
            if (this.Hand[pictureBoxIndex].Face >= this.Hand.HighestCards()[0].Face)
            {
                this.CurrentClickedCard.BackColor = Color.Green;
                UserMessageTextBox.Text = "You Got It!";

                //Uncomment this --> ScoreBoard.Score += this.MaximumPoints;

                DealButton.Enabled = true;
            }
            // otherwise Red
            else
            {
                CurrentClickedCard.BackColor = Color.Red;
                UserMessageTextBox.Text = "Try again ";
                UserMessageTextBox.Text += (Hand.HighestCardIndex > pictureBoxIndex) ? "to the right" : "to the left";
                this.MaximumPoints -= 20;
            }
        }

        /// <summary>
        /// This is a shared event handler for each of the CardPictureBoxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardPictureBox_Click(object sender, EventArgs e)
        {
            // get a reference to the PictureBox clicked
            PictureBox CardPictureBox = sender as PictureBox;
            this.CurrentClickedCard = CardPictureBox;
            this.CardFlipTimer.Enabled = true;
            this._showUserMessage();
        }

        /// <summary>
        /// This is the CardFlipTimer's "Tick" event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardFlipTimer_Tick(object sender, EventArgs e)
        {
            if ((this.CurrentClickedCard.Width % 11 == 0) || (this.CurrentClickedCard.Width == 0))
            {
                if (this.CurrentClickedCard.Width == 0)
                {
                    this._cardPictureBoxSetImage();
                }
                this.CurrentClickedCard.Width += 11;
            }

            if (this.CurrentClickedCard.Width % 12 == 0)
            {
                this.CurrentClickedCard.Width -= 12;
            }

            if (this.CurrentClickedCard.Width >= 96)
            {
                this.CurrentClickedCard.Width = 96;
                CardFlipTimer.Enabled = false;
            }

        }

        /// <summary>
        /// This method disables all the Dealt Card Picture Boxes
        /// </summary>
        private void _disableDealtCards()
        {
            foreach (var card in DealtCardPictureBoxList)
            {
                card.Enabled = false;
            }
        }

        /// <summary>
        /// This method enables all the Dealt Card Picture Boxes
        /// </summary>
        private void _enableDealtCards()
        {
            foreach (var card in DealtCardPictureBoxList)
            {
                card.Enabled = true;
            }
        }

        /// <summary>
        /// This is the CountDownTimer's "Tick" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountDownTimer_Tick(object sender, EventArgs e)
        {
            /* Uncomment THIS
            ScoreBoard.UpdateTime();
            if (ScoreBoard.Time == 0)
            {
                CountDownTimer.Enabled = false;
                DealButton.Enabled = false;
                this._disableDealtCards();
                this._showFinalScore();
            }
            */
        }

        /// <summary>
        /// This method shows the Final Score Label and Text Box
        /// </summary>
        private void _showFinalScore()
        {
            FinalScoreLabel.Visible = true;
            FinalScoreTextBox.Visible = true;
        }

        /// <summary>
        /// This method hides the Final Score Label and Text Box
        /// </summary>
        private void _hideFinalScore()
        {
            FinalScoreLabel.Visible = false;
            FinalScoreTextBox.Visible = false;
        }

        /// <summary>
        /// This is the ExitButton's "Click" event handler method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
