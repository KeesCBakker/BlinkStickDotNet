using System.Drawing;
using System.Threading;
using BlinkStickDotNet;
using BlinkStickDotNet.Animations;
using BlinkStickDotNet.Animations.Implementations;

namespace DemoApp
{
    public interface ISimpleStickController
    {
        /// <summary>
        /// Set all to white
        /// </summary>
        void SetWhite();
        /// <summary>
        /// Set all to red
        /// </summary>
        void SetRed();
        /// <summary>
        /// Blinks green and then returns to previous color
        /// </summary>
        void BlinkGreen();
        /// <summary>
        /// Turn off all
        /// </summary>
        void TurnOff();
    }

    public class SimpleStickController : ISimpleStickController
    {
        public void SetWhite()
        {
            var sticks = BlinkStick.FindAll();
            foreach (BlinkStick blinkStick in sticks)
            {
                var finished = new ManualResetEvent(false);

                var q = new Animator();
                q.Morph(1000, Color.Chocolate);
                q.Queue(new ActionAnimation((p) =>
                {
                    finished.Set();
                }));

                q.Connect(blinkStick);
                q.Start();

                finished.WaitOne();
            }
        }

        public void SetRed()
        {
            var sticks = BlinkStick.FindAll();
            foreach (BlinkStick blinkStick in sticks)
            {
                var finished = new ManualResetEvent(false);

                var q = new Animator();
                q.Morph(1000, Color.Red);
                q.Queue(new ActionAnimation((p) =>
                {
                    finished.Set();
                }));

                q.Connect(blinkStick);
                q.Start();

                finished.WaitOne();
            }
        }

        public void BlinkGreen()
        {
            var sticks = BlinkStick.FindAll();
            foreach (BlinkStick blinkStick in sticks)
            {
                blinkStick.OpenDevice();
                blinkStick.GetColors(out var colors);

                var finished = new ManualResetEvent(false);

                var q = new Animator();
                q.Pulse(1000, Color.Green);
                q.Pulse(1000, Color.Green);
                q.Queue(new ActionAnimation((p) =>
                {
                    finished.Set();
                }));

                q.Connect(blinkStick);
                q.Start();

                finished.WaitOne();
                blinkStick.SetColors(0, colors);
            }
        }

        public void TurnOff()
        {
            var sticks = BlinkStick.FindAll();
            foreach (BlinkStick blinkStick in sticks)
            {
                blinkStick.OpenDevice();
                //for (int i = 0; i < blinkStick.GetLedCount(); i++)
                //{
                //    blinkStick.SetColor(0, (byte)i, 0, 0, 0);
                //}

                blinkStick.TurnOff();
            }
        }
    }
}
