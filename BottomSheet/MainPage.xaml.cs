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
            currentY = 0;
        }

        /*
         * Important code lies below
         */

        private double y;
        private bool IsTurnY;
        private double valueY;
        private double currentY;

        void PanGestureRecognizer_PanUpdated(System.Object sender, Xamarin.Forms.PanUpdatedEventArgs e)
        {
            y = e.TotalY;

            switch (e.StatusType)
            {
                case GestureStatus.Started:
                    break;
                case GestureStatus.Canceled:
                    break;
                case GestureStatus.Running:
                    if (Device.Android == Device.RuntimePlatform)
                    {
                        MethodLockedSync(() =>
                        {

                            Device.BeginInvokeOnMainThread(() =>
                            {


                                if ((y >= 5 || y <= -5) && !IsTurnY)
                                {
                                    IsTurnY = true;
                                }

                                if (IsTurnY)
                                {

                                    if (y <= valueY)
                                    {
                                        //upwards dragged
                                        
                                    if ((currentY + (-1 * y)) < (App.screenHeight - 180))
                                        {
                                            BottomSheet.TranslateTo(BottomSheet.X, -(currentY + (-1 * y)));
                                            currentY = currentY - y;
                                        //Task.Delay(200);
                                    }
                                        else
                                        {

                                            //to avoid the bottomsheet go beyond the device height
                                             
                                            BottomSheet.TranslateTo(BottomSheet.X, -(App.screenHeight - 180));
                                            currentY = (App.screenHeight - 180);
                                        }
                                    }
                                    if (y >= valueY)
                                    {
                                    //downwards dragged
                                    if ((currentY - y) > 0)
                                        {
                                            BottomSheet.TranslateTo(BottomSheet.X, -(currentY - y));
                                            currentY = currentY - y;
                                        //Task.Delay(200);
                                    }
                                        else
                                        {
                                        //to avoid bottomsheet to hide below the screen height
                                        BottomSheet.TranslateTo(BottomSheet.X, -0);
                                            currentY = 0;
                                        }
                                    }
                                }
                            });
                        }, 2);
                    }
                    else
                    {
                        if ((y >= 5 || y <= -5) && !IsTurnY)
                        {
                            IsTurnY = true;
                        }

                        if (IsTurnY)
                        {

                            if (y <= valueY)
                            {
                                //iOS devices has top and bottom insets so the value is changed accordingly.
                                //get the top and bottom insets and adjst the values accordingly for bottom sheet to work correct in real devices
                                double valueToDeduct = 180;
                                
                                //upwards dragged
                                if ((currentY + (-1 * y)) < (App.screenHeight - valueToDeduct))
                                {
                                    BottomSheet.TranslateTo(BottomSheet.X, -(currentY + (-1 * y)));
                                    currentY = currentY - y;
                                    //Task.Delay(200);
                                }
                                else
                                {
                                    //to avoid the bottomsheet go beyond the device height
                                    BottomSheet.TranslateTo(BottomSheet.X, -(App.screenHeight - valueToDeduct));
                                    currentY = (App.screenHeight - valueToDeduct);
                                }
                            }
                            if (y >= valueY)
                            {
                                //downwards dragged
                                if ((currentY - y) > 0)
                                {
                                    BottomSheet.TranslateTo(BottomSheet.X, -(currentY - y));
                                    currentY = currentY - y;
                                    //Task.Delay(200);
                                }
                                else
                                {
                                    //to avoid bottomsheet to hide below the screen height
                                    BottomSheet.TranslateTo(BottomSheet.X, -0);
                                    currentY = 0;
                                }
                            }

                        }
                        }
                    break;

                case GestureStatus.Completed:
                    //store the translation applied during the pan
                    valueY = y;
                    IsTurnY = false;
                    break;
            }
        }

        private CancellationTokenSource _throttleCts = new CancellationTokenSource();
        private void MethodLockedSync(Action method,double timeDelay = 500)
        {
            Interlocked.Exchange(ref _throttleCts, new CancellationTokenSource()).Cancel();
            Task.Delay(TimeSpan.FromMilliseconds(timeDelay), _throttleCts.Token)
                .ContinueWith(
                delegate { method(); },
                CancellationToken.None,
                TaskContinuationOptions.OnlyOnRanToCompletion,
                TaskScheduler.FromCurrentSynchronizationContext()
                );
        }
    }
}
