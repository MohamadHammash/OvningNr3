using System;
using System.Collections.Generic;
using System.Text;

namespace OvningNr3
{
    public abstract class UserError
    {
        public abstract string UEMessage();
        
    }
    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numericonly field.This fired an error!";
        }

    }
}
