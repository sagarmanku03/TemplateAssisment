using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateAssisment
{
    public class RRClass
    {
        int Bullet = 0;
        int Chances = 3;
        public void ShootAtHead()
        {
            //In the event that the slug is in the barrel, shoot it at head
            if (Bullet == 5)
            {
                MessageBox.Show("You loose!");
            }
            else
            {
                MessageBox.Show("The pistol simply turned");
                Bullet = Bullet + 1;
            }


        }
        public void ShootAway()
        {
            //if I get opportunity
            if (Chances > 0)
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You remain alive");
                }
                else
                {
                    //In the event that you are not shooting, the pistol pivots
                    MessageBox.Show("The pistol simply turned");
                    Bullet = Bullet + 1;
                }
            }
        }
        public void SpinChamber()
        {
            Random rand = new Random();
           Bullet = rand.Next(0, 5);
            MessageBox.Show("Weapon spin");

        }
        public void ReloadRevolver()
        {
            Bullet = 0;
            MessageBox.Show("weapon is reloaded");
        }

    }
}
    
