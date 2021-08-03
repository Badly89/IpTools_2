// Decompiled with JetBrains decompiler
// Type: Suprug.Transfer
// Assembly: Suprug, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F471ACA2-82E7-452D-BC67-1F55BF48ED1E
// Assembly location: D:\!!Личное\Apeha\OPtools\ОП tools.exe

namespace OpTools
{
    public class Transfer
    {
        private int id;
        private Event trans;
        private bool isOk;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public Event Trans
        {
            get
            {
                return this.trans;
            }
            set
            {
                this.trans = value;
            }
        }

        public bool IsOk
        {
            get
            {
                return this.isOk;
            }
            set
            {
                this.isOk = value;
            }
        }
    }
}
