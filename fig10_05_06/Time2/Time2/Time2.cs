// Fig. 10.5: Time2.cs
// Time2 class declaration with overloaded constructors.  
using System; // for class ArgumentOutOfRangeException

public class Time2
{
   private int hour; // 0 - 23
   private int minute; // 0 - 59
   private int second; // 0 - 59


   /// <summary>
   /// constructor can be called with zero, one, two or three arguments 
   /// </summary>
   /// <param name="h">int</param>
   /// <param name="m">int</param>
   /// <param name="s">int</param>
   public Time2(int h = 0, int m = 0, int s = 0)
   {
      SetTime(h, m, s); // invoke SetTime to validate time
   } // end Time2 three-argument constructor 

  
   /// <summary>
   /// Time2 constructor: another Time2 object supplied as an argument
   /// </summary>
   /// <param name="time"></param>
   public Time2(Time2 time)
      : this(time.Hour, time.Minute, time.Second) { }


   /// <summary>
   /// set a new time value using universal time; ensure that 
   /// the data remains consistent by setting invalid values to zero
   /// </summary>
   /// <param name="h">int</param>
   /// <param name="m">int</param>
   /// <param name="s">int</param>
   public void SetTime(int h, int m, int s)
   {
      Hour = h; // set the Hour property
      Minute = m; // set the Minute property
      Second = s; // set the Second property
   } // end method SetTime


   /// <summary>
   /// property that gets and sets the hour 
   /// </summary>
   public int Hour
   {
      get
      {
         return hour;
      } // end get
      set
      {
         if (value >= 0 && value < 24)
            hour = value;
         else
            throw new ArgumentOutOfRangeException(
               "Hour", value, "Hour must be 0-23");
      } // end set
   } // end property Hour


   /// <summary>
   /// property that gets and sets the minute
   /// </summary>
   public int Minute
   {
      get
      {
         return minute;
      } // end get
      set
      {
         if (value >= 0 && value < 60)
            minute = value;
         else
            throw new ArgumentOutOfRangeException(
               "Minute", value, "Minute must be 0-59");
      } // end set
   } // end property Minute

 
   /// <summary>
   /// property that gets and sets the second
   /// </summary>
   public int Second
   {
      get
      {
         return second;
      } // end get
      set
      {
         if (value >= 0 && value < 60)
            second = value;
         else
            throw new ArgumentOutOfRangeException(
               "Second", value, "Second must be 0-59");
      } // end set
   } // end property Second


   /// <summary>
   /// convert to string in universal-time format (HH:MM:SS) 
   /// </summary>
   /// <returns>string</returns>
   public string ToUniversalString()
   {
      return string.Format(
         "{0:D2}:{1:D2}:{2:D2}", Hour, Minute, Second);
   } // end method ToUniversalString

  
   /// <summary>
   /// convert to string in standard-time format (H:MM:SS AM or PM)
   /// </summary>
   /// <returns>string</returns>
   public override string ToString()
   {
      return string.Format("{0}:{1:D2}:{2:D2} {3}",
         ((Hour == 0 || Hour == 12) ? 12 : Hour % 12),
         Minute, Second, (Hour < 12 ? "AM" : "PM"));
   } // end method ToString
} // end class Time2

/**************************************************************************
 * (C) Copyright 1992-2014 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
