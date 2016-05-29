using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer.Playlist
{
    class ListView_to_Playlist
    {
        Form1 frm1 = (Form1)Application.OpenForms["Form1"];
        IWMPPlaylist plylst = null;
        int secilen;
        //Sırasıyla Parçaların alınacağı ListView, dosya yolunun bulunduğu sütunun indexi, playlist ismi, hangi parçaya tıklandığı... bilgilerini alır.
        public ListView_to_Playlist(ListView lvisim, int urlSUtunNo, string plisim, int secilenItem = 0)
        {
            secilen = secilenItem;
            plylst = frm1.axWindowsMediaPlayer1.playlistCollection.newPlaylist(plisim);

            foreach (ListViewItem pl in lvisim.Items) //ListView satır sayısı kadar döngüye giriliyor.
            {
                IWMPMedia media = frm1.axWindowsMediaPlayer1.newMedia(pl.SubItems[urlSUtunNo].Text); //Yeni media nesnesi oluşturuluyor ve listview.itemin ilgili sütunundan url alınıyor.
                plylst.appendItem(media); //Oluşturulan medya "Listeye" ekleniyor.
            }
        }

        public IWMPPlaylist Playlist() //Playlist döndürülüyor.
        {
            return plylst;
        }

        public int Secilen()
        {
            return secilen;
        }

        public void sil() //Playlist siliniyor.
        {
            plylst.clear();
            secilen = 0;
        }
    }
}
