using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMain
{
	public class ImageUpload
	{
		public string UploadIMG()
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";// 設定檔案篩選器，只允許選擇圖片檔案（jpg、jpeg、png 格式）
			string picture = string.Empty;  // 初始化圖片路徑為空字串
			if (openFileDialog.ShowDialog() == DialogResult.OK) // 如果使用者選擇了檔案並按下「確定」按鈕
			{
				picture = openFileDialog.FileName;  // 取得選擇的圖片路徑
			}
			return picture;
		}
		public string SaveImage(string filePath)
		{
            Bitmap images = new Bitmap(filePath); //產生圖片物件

            Random rand = new Random(Guid.NewGuid().GetHashCode()); //產生亂數以產生名字
            string fileExt = Path.GetExtension(filePath); //取得副檔名
            string name = rand.Next(10001, 99999).ToString(); //產生新檔名
            string savePath = @"images/" + name + fileExt; //產生新圖片路徑
            images.Save(savePath); //儲存到新路徑
            return savePath;

        }
	}
	
}
