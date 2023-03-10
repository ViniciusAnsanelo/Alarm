using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Alarm
{
    public class Alarme
    {
        //construtor
        public Alarme()
        {
            this.time = 3;
        }

        public Alarme(int time)
        {
            this.time = time;
        }

        //atributos 

        private int time;

        public int Time
        {
            get { return this.time; }
            set { this.time = 60000 * value; }
        }

        public void Start()
        {
            //to work must add system.Threading;
            Thread.Sleep(this.Time);
            //define frequency and duration of the sound;
            Console.Beep(250, 10);
        }


    }
