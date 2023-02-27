using Sharp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace htv5_mixer_control
{
    public class ReadVariablesPLC
    {
        private S7Client Client;
        private string _IP;
        private int _Rack;
        private int _Slot;
        private byte[] Buffer = new byte[65536];
        private byte[] DB_A = new byte[1024];
        private byte[] DB_B = new byte[1024];
        private byte[] DB_C = new byte[1024];
        private byte[] DB_D = new byte[1024];
        public string ConnectionMessage;

        public ReadVariablesPLC(string IP, int Rack, int Slot, out int Result)
        {
            Client = new S7Client();
            _IP = IP;
            _Rack = Rack;
            _Rack = Slot;
            Client.ConnTimeout = 500;
            Client.RecvTimeout = 500;
            Client.SendTimeout = 500;
            Result = Client.ConnectTo(_IP, _Rack, _Slot);
            if (Result == 0)
            {
                ConnectionMessage = Client.ErrorText(Result);
            }
            var StrMessage = Client.ErrorText(0);
        }
        public int Diconnect()
        {
            int Result = -1;
            try
            {
                Result = Client.Disconnect();
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Diconnect PLC fail", ex.Message);
            }
            return Result;
        }
        public int isConnectionPLC()
        {
            int Result = -1;
            try
            {
                Result = Client.ConnectTo(_IP, _Rack, _Slot);
                return Result;
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Connection PLC Error", ex.Message);
            }
            return Result;
        }
        public string ReadAreaByteToString(int DbNumber, int Start, int Amount)
        {
            string Result = "";
            try
            {
                Client.ReadArea(S7Area.DB, DbNumber, Start, Amount, S7WordLength.Byte, Buffer);
                for (int i = 0; i <= Amount - 1; i++)
                {
                    Result = Result + (Convert.ToString((char)Buffer[i]));
                }
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "ReadArea Byte to String fail", ex.Message);
            }
            return Result;

        }
        public void WriteQRMESto(int DbNumber, int Start, int Amount, string Text)
        {

            try
            {
                byte[] Buffer = new byte[65536];
                Sharp7.S7.SetCharsAt(Buffer, 0, Text);
                Client.WriteArea(S7Area.DB, DbNumber, Start, Amount, S7WordLength.Byte, Buffer);

            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "ReadArea Byte to String fail", ex.Message);
            }


        }
        public List<int> ReadAreaIntToListInt(int DbNumber, int Start, int Amount)
        {
            List<int> Result = new List<int>();
            try
            {
                Client.ReadArea(S7Area.DB, DbNumber, Start, Amount, S7WordLength.DInt, Buffer);
                for (int i = 0; i <= Amount - 1; i = i + 2)
                {
                    Result.Add(Buffer[i] * 256 + Buffer[i + 1]);
                }
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "ReadArea Byte to String fail", ex.Message);
            }
            return Result;

        }
        public List<int> ReadQuantityMQC()
        {
            List<int> listQuantity = new List<int>();
            try
            {
                S7MultiVar Reader = new S7MultiVar(Client);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 2, 2, 2, ref DB_A);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 3, 0, 2, ref DB_B);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 4, 0, 2, ref DB_C);
                var Result = Reader.Read();
                var intOK = Sharp7.S7.GetDIntAt(DB_A, 0);
                var intNG = Sharp7.S7.GetDIntAt(DB_B, 0);
                var intRW = Sharp7.S7.GetDIntAt(DB_C, 0);
                listQuantity.Add(DB_A[0] * 256 + DB_A[1]);
                listQuantity.Add(DB_B[0] * 256 + DB_B[1]);
                listQuantity.Add(DB_C[0] * 256 + DB_C[1]);
                return listQuantity;

            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Read Quantity fail", ex.Message);
            }
            return listQuantity;

        }
        public List<int> ReadQuantityMQCProduced()
        {
            List<int> listQuantity = new List<int>();
            try
            {
                S7MultiVar Reader = new S7MultiVar(Client);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 6, 4, 2, ref DB_A);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 6, 6, 2, ref DB_B);
                Reader.Add((int)S7Area.DB, (int)S7WordLength.DInt, 6, 8, 2, ref DB_C);
                var Result = Reader.Read();
                var intOK = Sharp7.S7.GetDIntAt(DB_A, 2);
                var intNG = Sharp7.S7.GetDIntAt(DB_B, 0);
                var intRW = Sharp7.S7.GetDIntAt(DB_C, 0);
                listQuantity.Add(intOK);
                listQuantity.Add(intNG);
                listQuantity.Add(intRW);
                return listQuantity;

            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Read Quantity fail", ex.Message);
            }
            return listQuantity;

        }
        public void WriteMQCProducedQuantitytoPLC(Int16 OutputQty, Int16 NGQty, Int16 RWQty)
        {
            try
            {


                byte[] BufferOP = new byte[2];
                byte[] BufferNG = new byte[2];
                byte[] BufferRW = new byte[2];

                Sharp7.S7.SetWordAt(BufferOP, 0, ushort.Parse(OutputQty.ToString()));
                Sharp7.S7.SetWordAt(BufferNG, 0, ushort.Parse(NGQty.ToString()));
                Sharp7.S7.SetWordAt(BufferRW, 0, ushort.Parse(RWQty.ToString()));
                int Result;
                Result = Client.WriteArea(S7Area.DB, 181, 210, 2, S7WordLength.Byte, BufferOP);
                Result = Client.WriteArea(S7Area.DB, 181, 212, 2, S7WordLength.Byte, BufferNG);
                Result = Client.WriteArea(S7Area.DB, 181, 214, 2, S7WordLength.Byte, BufferRW);
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Write MQC Produced Quatity to PLC", ex.Message);
            }

        }
        public bool ReadBitToBool(int db, int start, int bit, int size)
        {
            bool Result = false;
            try
            {
                byte[] buffer = new byte[1];

                Client.DBRead(db, start, size, buffer);
                Result = Sharp7.S7.GetBitAt(buffer, 0, bit);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "ReadArea Byte to String fail", ex.Message);
            }
            return Result;

        }
        public void WritebittoPLC(bool value, int db, int start, int bit, int size)
        {
            try
            {
                byte[] buffer = new byte[1];
                Sharp7.S7.SetBitAt(buffer, 0, bit, value);
                Client.DBWrite(db, start, size, buffer);
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Write bit to PLC fail", ex.Message);
            }
        }
        public string ReadRealToString(int DbNumber, int Start)
        {
            string Result = "";
            try
            {
                byte[] buffer = new byte[4];

                Client.ReadArea(S7Area.DB, DbNumber, Start, 4, S7WordLength.Byte, buffer);
                Result = Convert.ToString(Sharp7.S7.GetRealAt(buffer, 0));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "ReadArea Byte to String fail", ex.Message);
            }
            return Result;

        }
        public void WriteRealtoPLC(float value, int db, int start, int size)
        {
            try
            {
                byte[] buffer = new byte[4];
                Sharp7.S7.SetRealAt(buffer, 0, value);
                Client.WriteArea(S7Area.DB, db, start, 4, S7WordLength.Byte, buffer);
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Write Dint to PLC fail", ex.Message);
            }
        }
        public void WriteDinttoPLC(int value, int db, int start, int size)
        {
            try
            {
                byte[] buffer = new byte[2];
                Sharp7.S7.SetWordAt(buffer, 0, ushort.Parse(value.ToString()));
                Client.WriteArea(S7Area.DB, db, start, 2, S7WordLength.Byte, buffer);
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Write Dint to PLC fail", ex.Message);
            }
        }

        public void WriteStringtoPLC(string value, int db, int start, int size)
        {
            try
            {
                byte[] buffer = new byte[254];
                Sharp7.S7.SetStringAt(buffer, 0, 254, value);
                //Sharp7.S7.SetWordAt(buffer, 0, ushort.Parse(value.ToString()));
                Client.WriteArea(S7Area.DB, db, start, 254, S7WordLength.Byte, buffer);
            }
            catch (Exception ex)
            {

                //SystemLog.Output(SystemLog.MSG_TYPE.Err, "Write Dint to PLC fail", ex.Message);
            }
        }
    }
}
