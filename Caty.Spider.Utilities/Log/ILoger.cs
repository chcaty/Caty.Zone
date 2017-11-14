using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caty.Spider.Utilities.Log
{
    public interface ILoger
    {
        void Write(string msg);
        void Write(string msg, LogMessageType type);
        void Write(string message, LogMessageType messageType, Type type);
        void Write(string message, LogMessageType messageType, Exception ex);

        void Write(string message, LogMessageType messageType, Exception ex, Type type);

        void Write<T>(T entity, LogMessageType messageType);
        void Write<T>(T entity, LogMessageType messageType, Exception ex, Type type);

        void Assert(bool condition, string message);
        void Assert(bool condition, string message, Type type);
    }
}
