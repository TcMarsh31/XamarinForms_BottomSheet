using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BottomSheet
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public IList<Monkey> Monkeys { get; private set; }
        double yHalfPosition;
        double yFullPosition;
        double yZeroPosition;
        int currentPsotion;
        double currentPostionY;
        bool up;
        bool down;
        bool isTurnY;
        double valueY;
        double y;

        public MainPage()
        {
            InitializeComponent();

            Monkeys = new List<Monkey>();
            Monkeys.Add(new Monkey
            {
                Name = "Baboon",
                Location = "Africa & Asia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Capuchin Monkey",
                Location = "Central & South America",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Blue Monkey",
                Location = "Central and East Africa",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Squirrel Monkey",
                Location = "Central & South America",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Lion Tamarin",
                Location = "Brazil",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Howler Monkey",
                Location = "South America",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Japanese Macaque",
                Location = "Japan",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Mandrill",
                Location = "Southern Cameroon, Gabon, Equatorial Guinea, and Congo",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Proboscis Monkey",
                Location = "Borneo",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_Monkey_in_Borneo.jpg/250px-Proboscis_Monkey_in_Borneo.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Red-shanked Douc",
                Location = "Vietnam, Laos",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gray-shanked Douc",
                Location = "Vietnam",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Golden Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_Monkeys%2C_Qinling_Mountains_-_China.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Black Snub-nosed Monkey",
                Location = "China",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Tonkin Snub-nosed Monkey",
                Location = "Vietnam",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_monkeys_%28Rhinopithecus_avunculus%29.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Thomas's Langur",
                Location = "Indonesia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Purple-faced Langur",
                Location = "Sri Lanka",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            });

            Monkeys.Add(new Monkey
            {
                Name = "Gelada",
                Location = "Ethiopia",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/13/Gelada-Pavian.jpg/320px-Gelada-Pavian.jpg"
            });

            BindingContext = this;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            yHalfPosition = (App.screenHeight / 2) - 60;
            yFullPosition = App.screenHeight - 190;
            if (Device.RuntimePlatform == Device.iOS)
            {
                yFullPosition = App.screenHeight - (20 + 20 + 30 + 120);
            }
            yZeroPosition = 0;
            currentPsotion = 1;
            currentPostionY = yHalfPosition;

            bottomSheet.TranslateTo(bottomSheet.X, -yHalfPosition);
        }

        /*
         * Important code lies below
         */



        void PanGestureRecognizer_PanUpdated(System.Object sender, Xamarin.Forms.PanUpdatedEventArgs e)
        {
            // Handle the pan
            switch (e.StatusType)
            {
                case GestureStatus.Running:
                    // Translate and ensure we don't y + e.TotalY pan beyond the wrapped user interface element bounds.
                    var translateY = Math.Max(Math.Min(0, y + e.TotalY), -Math.Abs((Height * .25) - Height));
                    //bottomSheet.TranslateTo(bottomSheet.X, -1*(currentPostionY+(-1*translateY)),20); //up working good



                    if (e.TotalY >= 5 || e.TotalY <= -5 && !isTurnY)
                    {
                        isTurnY = true;
                    }
                    if (isTurnY)
                    {
                        if (e.TotalY <= valueY)
                        {
                            up = true;

                        }
                        if (e.TotalY >= valueY)
                        {
                            down = true;

                        }
                    }
                    if (up)
                    {
                        if (Device.RuntimePlatform == Device.Android)
                        {
                            if (yFullPosition < (currentPostionY + (-1 * e.TotalY)))
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -yFullPosition);
                            }
                            else
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -1 * (currentPostionY + (-1 * e.TotalY)));
                            }
                        }
                        else
                        {
                            if (yFullPosition < (currentPostionY + (-1 * e.TotalY)))
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -yFullPosition, 20);
                            }
                            else
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -1 * (currentPostionY + (-1 * e.TotalY)), 20);
                            }
                        }
                    }
                    else if (down)
                    {
                        if (Device.RuntimePlatform == Device.Android)
                        {
                            if (yZeroPosition > currentPostionY - e.TotalY)
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -yZeroPosition);
                            }
                            else
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -(currentPostionY - (e.TotalY)));
                            }
                        }
                        else
                        {
                            if (yZeroPosition > currentPostionY - e.TotalY)
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -yZeroPosition, 20);
                            }
                            else
                            {
                                bottomSheet.TranslateTo(bottomSheet.X, -(currentPostionY - (e.TotalY)), 20);
                            }
                        }
                    }
                    break;
                case GestureStatus.Completed:
                    // Store the translation applied during the pan
                    valueY = e.TotalY;
                    y = bottomSheet.TranslationY;

                    //at the end of the event - snap to the closest location
                    //var finalTranslation = Math.Max(Math.Min(0, -1000), -Math.Abs(getClosestLockState(e.TotalY + y)));

                    //depending on Swipe Up or Down - change the snapping animation
                    if (up)
                    {
                        //swipe up happened
                        if (currentPsotion == 1)
                        {
                            bottomSheet.TranslateTo(bottomSheet.X, -yFullPosition);
                            currentPsotion = 2;
                            currentPostionY = yFullPosition;
                            //bottomSheet.TranslateTo(bottomSheet.X, finalTranslation, 250, Easing.SpringIn);
                        }
                        else if (currentPsotion == 0)
                        {
                            bottomSheet.TranslateTo(bottomSheet.X, -yHalfPosition);
                            currentPsotion = 1;
                            currentPostionY = yHalfPosition;
                        }

                    }
                    if (down)
                    {
                        //swipe down happened
                        if (currentPsotion == 1)
                        {
                            bottomSheet.TranslateTo(bottomSheet.X, -yZeroPosition);
                            currentPsotion = 0;
                            currentPostionY = yZeroPosition;
                        }
                        else if (currentPsotion == 2)
                        {
                            bottomSheet.TranslateTo(bottomSheet.X, -yHalfPosition);
                            currentPsotion = 1;
                            currentPostionY = yHalfPosition;
                        }
                        //bottomSheet.TranslateTo(bottomSheet.X, finalTranslation, 250, Easing.SpringOut);
                    }

                    //dismiss the keyboard after a transition
                    //SearchBox.Unfocus();
                    y = bottomSheet.TranslationY;
                    up = false;
                    down = false;
                    break;

            }
        }
    }
}
