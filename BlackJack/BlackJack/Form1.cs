using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Hit_Button.Enabled = false;
            Stay_Button.Enabled = false;
            Loan_Button.Enabled = false;
            HUDTextBox.Text = "Welcome! Specify an amount of credit and press the (Bet) button to start!";
        }

        
        
        
        Random random = new Random(); //Needed to generate random numbers

        
        int userPoints = 0; //Stores tha sum of points of the player's hand
        int dealerPoints = 0; //Stores tha sum of points of the dealer's hand
        int CardValue =0; //stors the value of a card
        string [] dealtCards = new string [50]; // an array to store the dealt cards (so far)
        int DealtCardsCounter = 0; //an int to keep track of the amount of dealt cards
        bool UserAce; // A boolean to keep track if the player gets an Ace
        bool DealerAce; // A boolean to keep track if the dealer gets an Ace
        string CardName; //Stores the name of the card
        string HiddenCardName; //Stores the name of the hidden card the dealer gets
        int randNumFace; //Stores the randomly generated number used for a card face value (6,7,Q,K...) 
        int randNumSuite; //Stores the randomly generated number used for a card suite (Spades, Diamonds...)
        bool UserAceAdded; // A boolean to keep track if the player's Ace extra 10 points was added to the points.
        bool DealerAceAdded; // A boolean to keep track if the player's Ace extra 10 points was added to the points.
        decimal UserCredits = 200; //Stores the players credits.
        decimal Bet;

        
        string[] cardFace = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] cardSuites = { "Spades", "Diamonds", "Hearts", "Clover" };



        public void RestartGame() //A method for restarting the game
        {
            
            Hit_Button.Enabled = false;
            Stay_Button.Enabled = false;
            Loan_Button.Enabled = false;
            Bet_Button.Enabled = true;
            textBox1.Enabled = true;
            HUDTextBox.Text = "Game Restarted!";

            ShuffleCards();
            userPoints = 0;
            dealerPoints = 0;
            CardValue = 0;
            DealtCardsCounter = 0;
            UserAce = false;
            DealerAce = false; 
            UserAceAdded = false;
            DealerAceAdded = false;
            UserCredits = 200;
            Bet = 0;

            PlayerTextBox.Text = "";
            DealerTextbox.Text = "";
            dealerPointsDisplay.Text = "";
            userPointsDisplay.Text = "";
            textBox1.Clear();
            CashDisplay.Text = UserCredits.ToString();           

        }

        public int getCardValue(int randNumFace) //Returns a card Value
        {
            //the cards face array is arranged from ace, number to J,Q,K cards
            //The card value is card index + 1 if its under 10
            //This way cards 2-10 gets thier face value, J,Q,K gets 10 value points
            //The Ace gets 1 point but it gets a special treatement later.
            if (randNumFace < 10)
            {
                CardValue = randNumFace + 1;
            }
            else
            {
                CardValue = 10;
            }
            return CardValue;
        }

        public void GiveCard(string CardReciever)
        {
            //The method gives a card based on the string CardReciever,
            //it can be (Player, dealer, and Dealer Hidden)

            bool CardIsNew = false;

            while (CardIsNew == false)
            {
                CardIsNew = true;
            //Generate card block---------------------------------------------------------
            randNumFace = random.Next(0, 13); //Random number for Cardface
            randNumSuite = random.Next(0, 4); //Random number for Card Suite

                

            CardValue = getCardValue(randNumFace); //Decide n Store card value in CardValue
            CardName = (cardFace[randNumFace] + " of " + cardSuites[randNumSuite]);
            //------------------------------------------------------------------

            //If the generated card exists in dealtCards, restart the button to generate another,
            //otherwise, saves it in dealtCards
            for (int i = 0; i < dealtCards.Length; i++)
            {
                if (CardName == dealtCards[i])
                {
                    CardIsNew = false;
                }

            }

            }
            
            //Here Where the Ace is going is Controlled
            if (randNumFace == 0)
            {
                switch (CardReciever)
                {
                    case "Player":
                        UserAce = true;
                        break;

                    case "Dealer":
                        DealerAce = true;
                        break;

                    case "DealerHiddenCard":
                        DealerAce = true;
                        break;
                }
            }
            
            //Saves the card in dealtCrds and increases the card counter
            dealtCards[DealtCardsCounter] = CardName;
            DealtCardsCounter++;


            //Adds card name value and displays them
            switch (CardReciever)
            { 
             case "Player":
                 PlayerTextBox.Text += CardName + "\n";
                userPoints += CardValue;
                    UserAceManagement();
                    userPointsDisplay.Text = userPoints.ToString();
                break;

                case "Dealer":
                    DealerTextbox.Text += CardName + "\n";
                    dealerPoints += CardValue;
                    DealerAceManagement();
                    dealerPointsDisplay.Text = dealerPoints.ToString();
                    break ;

                case "DealerHiddenCard":
                    HiddenCardName = CardName;
                    DealerTextbox.Text += "Hidden Card" + "\n";
                    dealerPoints += CardValue;
                    DealerAceManagement();
                    dealerPointsDisplay.Text = "??";
                    break;
            }

            

        }

        public void UserLost() //When the user loses
        {
            
            RevealDealersHiddenCard();
            dealerPointsDisplay.Text = dealerPoints.ToString();
            Hit_Button.Enabled = false;
            Stay_Button.Enabled = false;
            HUDTextBox.Text = "You Lost";
            Bet_Button.Enabled = true;
            
            userPoints = 0;
            dealerPoints = 0;
            UserAce = false;
            DealerAce = false;
            UserAceAdded = false;
            DealerAceAdded = false;
            
            UserCredits -= Bet;

            
            CashDisplay.Text = UserCredits.ToString(); //Updates credit display
            
            textBox1.Enabled = true; //Enables credit amount input
            UserBankrupcyCheck();
        }

        public void UserBankrupcyCheck() //Checks if the user is bankrupt
        {
            if (UserCredits == 0)
            {
                textBox1.Enabled = false;
                Bet_Button.Enabled = false;
                Hit_Button.Enabled = false;
                Stay_Button.Enabled = false;
                Loan_Button.Enabled = true;

                HUDTextBox.Text = "Youre out of credit! Press the (Take a Loan!) button to take a convenient 500% interest loan from the Mafia!";
            }


        }

        public void CheckIfUserPoints21() //Checks if th useer gets a 21 in the opening hand
        {
            if (userPoints == 21)
            {
                dealerPointsDisplay.Text = dealerPoints.ToString();
                Hit_Button.Enabled = false;
                Stay_Button.Enabled = false;
                HUDTextBox.Text = "Your cards adds up to 21 points! You Won 1.5 times your bet!";
                Bet_Button.Enabled = true;
                userPoints = 0;
                dealerPoints = 0;
                UserAce = false;
                DealerAce = false;
                UserAceAdded = false;
                DealerAceAdded = false;
                UserCredits = (UserCredits + (Bet) + (Bet/2));
                CashDisplay.Text = UserCredits.ToString();
                textBox1.Enabled = true; //Enables credit amount input

            }
        }

        public void UserWon() //If the player wins
        {
            dealerPointsDisplay.Text = dealerPoints.ToString();
            HUDTextBox.Text = "You Won";
            Hit_Button.Enabled = false;
            Stay_Button.Enabled = false;
            Bet_Button.Enabled = true;
            userPoints = 0;
            dealerPoints = 0;
            UserAce = false;
            DealerAce = false;
            UserAceAdded = false;
            DealerAceAdded = false;
            
            UserCredits += Bet; 
                        
            CashDisplay.Text = UserCredits.ToString(); //Updates credit display

            textBox1.Enabled = true; //Enables credit amount input

        }

        public void ItsATie()
        {
            dealerPointsDisplay.Text = dealerPoints.ToString();
            Hit_Button.Enabled = false;
            Stay_Button.Enabled = false;
            HUDTextBox.Text = "Its a tie (push)";
            Bet_Button.Enabled = true;
            userPoints = 0;
            dealerPoints = 0;
            UserAce = false;
            DealerAce = false;
            UserAceAdded = false;
            DealerAceAdded = false;
            textBox1.Enabled = true; //Enables credit amount input

        }

        public void CompareHands() //Compares  user and dealer hands
        {
            if (userPoints > dealerPoints)
            {
                UserWon();
            }
            
            else if (userPoints == dealerPoints)
            {
                ItsATie();
            }

            else
            {
                UserLost();
            }

        }


        public void ShuffleCards() //Shuffles the cards (Gets a new deck)
        {
            //There is no standard rule on when to shuffle the deck or get a new one;
            //but based on my findings, it seems to be when 50% to 75% of the deck is dealt;
            //so i though if 30 cards or more has been dealt, get a new deck.
            if (DealtCardsCounter >= 30)
            {
                for (int i = 0; i < dealtCards.Length; i++)
                {
                    dealtCards[i] = "";
                    
                }
                DealtCardsCounter = 0;

                Cards_Shuffled_Indicator.Text = "The deck is shuffled...";
            }
        }


        public void StartRound()
        {
            ShuffleCards();
            DealerTextbox.Text = "";
            PlayerTextBox.Text = "";
            HUDTextBox.Text = "";


            GiveCard("Player");
            GiveCard("Dealer");
            GiveCard("Player");
            GiveCard("DealerHiddenCard");
            
            

            Bet_Button.Enabled = false;
            Hit_Button.Enabled = true;
            Stay_Button.Enabled = true;


            CheckIfUserPoints21();


        }


        public void UserAceManagement() 
        {
            //Adds 10 points to the player hand If the player has an Ace and the sum dosent cause a bust,
            //after adding the points, the get deducted back if the sum exceeds 21.

            if (UserAce == true && userPoints + 10 <= 21)
            {
                userPoints += 10;
                UserAceAdded = true;
                UserAce = false;
            }
            if (UserAceAdded == true && userPoints > 21)
            {
                userPoints -= 10;
                UserAceAdded = false;
            }

        }

        public void DealerAceManagement()
        {
            //Adds 10 points to the dealer hand If the dealer has an Ace and the sum dosent cause a bust,
            //after adding the points, the get deducted back if the sum exceeds 21.

            if (DealerAce == true && dealerPoints + 10 <= 21)
            {
                dealerPoints += 10;
                DealerAceAdded = true;
                DealerAce = false;
            }
            if (DealerAceAdded == true && dealerPoints > 21)
            {
                dealerPoints -= 10;
                DealerAceAdded = false;
            }

        }

        public void RevealDealersHiddenCard() //To reveal the dealer's hidden card
        {
            string DealerTextBoxTextWithHiddenCard = DealerTextbox.Text;
            string DealerTextBoxTextWithRevealedCard = DealerTextBoxTextWithHiddenCard.Replace("Hidden Card", HiddenCardName);
            DealerTextbox.Text = DealerTextBoxTextWithRevealedCard;

        }

        private void betClicked(object sender, EventArgs e)
        {
            
            try
            {
                //Parses the Credit input box for an (int) and saves it as a (decimal) to hinder
                //the player from getting carried away and betting fractions.
                Bet = Int32.Parse(textBox1.Text); 
                
                if (Bet > 0 && Bet <= UserCredits && Bet != 0)
                {

                    textBox1.Enabled = false;
                    StartRound();
                    
                }
                else
                {
                    textBox1.Text = "";
                }


            }

            catch
            {

                textBox1.Text = "";

            }


        }

        private void Hit_Clicked(object sender, EventArgs e)
        {
            try
            {


                Cards_Shuffled_Indicator.Text = "";

                GiveCard("Player");


                if (userPoints > 21)
                {
                    UserLost();
                }
            }

            catch (Exception)
            { RestartGame();  }

        }

        private void Stay_Clicked(object sender, EventArgs e)
        {
            try
            {

                Cards_Shuffled_Indicator.Text = "";

                RevealDealersHiddenCard();

                while (dealerPoints <= 17)
                {
                    GiveCard("Dealer");

                }


                DealerAceManagement();


                if (dealerPoints > 21)
                {
                    UserWon();
                }
                else
                {
                    CompareHands();
                }
                
            }
            catch (Exception)
            { RestartGame(); }
        }

        private void Loan_Button_Clicked(object sender, EventArgs e) 
        {
            //Appears when the player is bankrupt to give a reasonable interest loan 
            try
            {

                UserCredits += 100;
                CashDisplay.Text = UserCredits.ToString();
                Loan_Button.Enabled = false;
                Bet_Button.Enabled = true;
                textBox1.Enabled = true;
                HUDTextBox.Text = "Done! Here is 100 credits! You must return them tomorrow with 600% interest! (This will definitely go well!)";
            }
            catch (Exception)
            { RestartGame(); }
        }

        private void Restart_Clicked(object sender, EventArgs e)
        {

            try
            {
                RestartGame();
            }
            catch (Exception)
            { }
        }
    }





}
