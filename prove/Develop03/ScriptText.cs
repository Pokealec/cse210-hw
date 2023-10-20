using System;
using System.Collections.Generic;

// this is where the scripture references and scriptures are located
public class ScriptText
{
  private Dictionary<string, string> _scrip = new(); // Make dictionary called _scrip
  public void makeDict(){
    _scrip.Add("Mosiah 3:19", "For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.");
    _scrip.Add("Amos 3:7", "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.");
    _scrip.Add("Moses 1:39", "For behold, this is my work and my glory— to bring to pass the immortality and eternal life of man.");
    _scrip.Add("Isaiah 1:18", "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.");
    _scrip.Add("Proverbs 3:5-6", "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");
    _scrip.Add("D&C 6:36", "Look unto me in every thought; doubt not, fear not.");
    _scrip.Add("Jacob 6:12", "O be wise; what can I say more?");
    _scrip.Add("1 Nephi 1:1", "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.");

}

public Dictionary<string, string> GetScript(){ // whole scripture as a string
  return _scrip;
}
  
}