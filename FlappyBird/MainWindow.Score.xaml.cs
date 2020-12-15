using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;


namespace FlappyBird
{
    /// Interaction logic for MainWindow.xaml
    public partial class MainWindow : Window
    {
        private int score = 0;
        private int bestScore = 0;

        private void displayScoreboard()
        {
            scoreboard.Visibility = Visibility.Visible;
            restartButton.Visibility = Visibility.Visible;
            scoreButton.Visibility = Visibility.Visible;
            //need to assign score and best score textboxes.
            updateScoreboard();
        }

        private void collapseScoreboard()
        {
            scoreboard.Visibility = Visibility.Collapsed;
            restartButton.Visibility = Visibility.Collapsed;
            scoreButton.Visibility = Visibility.Collapsed;
        }

        private void updateScoreboard()
        {
            //Update score first. 
            this.scoreTextBlock.Text = score.ToString();
            //Update best score next. 
            if (score > bestScore)
            {
                bestScore = score;
            }
            this.bestScoreTextBlock.Text = bestScore.ToString();
            ScoreContext scoreContext = new ScoreContext();
            Score scoreV = new Score();
            scoreV.ScoreValue = bestScore;
            scoreContext.Scores.Add(scoreV);
            scoreContext.SaveChanges();
        }
    }
}
