using System.Drawing;
using System.IO;

namespace GreatHomeChildcare
{
    class ImageWrangler
    {
        /* Convert student photo to byte array for saving to db.
         * Also used to see if the photo is too large for the db blob type.
         * INPUT: Object
         * OUPUT byte[] array
         * https://stackoverflow.com/questions/3801275/how-to-convert-image-to-byte-array
         */
        public static byte[] ImageToByteArray(Image imageIn)
        {
            if (imageIn == null)
                return null;

            if (imageIn == Properties.Resources.child)
                return null;

            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /* Convert student photo from byte array to object.
         * Convert a byte array to an Object
         * INPUT: byte[] array
         * OUTPUT: Image
         * https://stackoverflow.com/questions/9173904/byte-array-to-image-conversion
         */
        public static Image ByteArrayToImage(byte[] arrBytes)
        {
            using (var ms = new MemoryStream(arrBytes))
            {
                return Image.FromStream(ms);
            }
        }

        /* Nowhere else to put this.
         * Capitalize the first letter of a given string
         * then return the string.
         * Ref: https://www.educative.io/edpresso/how-to-capitalize-the-first-letter-of-a-string-in-c-sharp
         */
        public static string CapitalizeFirstLetter(string str)
        {
            if (str.Length <= 0)
                return null;
            else if (str.Length == 1)
                return char.ToUpper(str[0]).ToString();
            else
            {
                string output = string.Empty;
                output = char.ToUpper(str[0]).ToString();

                int i = 1;
                for(i=1; i < str.Length; i++)
                {
                    output += char.ToLower(str[i]).ToString();
                }

                return output;
            }
        }
    }
}
