using Unity.Collections;
using Unity.Networking.Transport;

namespace Net.NetMessage
{
    public class NetMessage
    {
        public OperationCode Code {set;get;}

        public virtual void Serialize(ref DataStreamWriter writer)
        {
            writer.WriteByte((byte)Code);
        }
        
        public virtual void Deserialize(ref DataStreamReader reader)
        {
            
        }
        
        public virtual void ReceivedOnClient( )
        {
            
        }
        
        public virtual void ReceivedOnServer(NetworkConnection conn)
        {
            
        }
    }
}

