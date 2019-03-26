package firma.eglenerekogreniyorum;

import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ViewFlipper;

public class Mevsimler extends AppCompatActivity implements View.OnClickListener {

    Button geriGit, ileriGit, otomatik;

    /*ViewFlipper, butona tıkladığında resmin efektif bir şekilde geçiş yapmasını sağlayan nesne diyebiliriz.*/
    ViewFlipper flipper;

    MediaPlayer yaz,kis,ilk,son;
    ImageButton bir,iki,uc,dort;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_mevsimler);

        /*tanımlamaları yaptık.*/

        geriGit = (Button) findViewById(R.id.bGeriGit);
        ileriGit = (Button) findViewById(R.id.bIleriGit);
        otomatik = (Button) findViewById(R.id.bOtomatik);
        flipper = (ViewFlipper) findViewById(R.id.vfFlipper);

        geriGit.setOnClickListener(this);
        ileriGit.setOnClickListener(this);
        otomatik.setOnClickListener(this);

        /*raw klasöründeki her medyayı burada butonla ilişkilendiriyoruz. Bu sayede tıklandığında raw klasöründeki ilgili medya işleme geçiyor.*/
        yaz=MediaPlayer.create(Mevsimler.this,R.raw.yaz);

        bir=(ImageButton)findViewById(R.id.imagebutton12);

        kis=MediaPlayer.create(Mevsimler.this,R.raw.kis);
        iki=(ImageButton)findViewById(R.id.imagebutton13);

        ilk=MediaPlayer.create(Mevsimler.this,R.raw.ilkbahar);
        uc=(ImageButton)findViewById(R.id.imagebutton14);

        son=MediaPlayer.create(Mevsimler.this,R.raw.sonbahar);
        dort=(ImageButton)findViewById(R.id.imagebutton15);

        /*butonlara tıklandığında medyaların işleme geçmesini sağlıyoruz.*/

        bir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                yaz.start();
            }});
        iki.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                kis.start();

            }
        });
        uc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ilk.start();

            }
        });
        dort.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                son.start();

            }
        });
    }

    @Override
    public void onClick(View view) {

        switch (view.getId()) {
            case R.id.bGeriGit:

                /* hangi görseldeysek o görselin efektini durdurarak geçiş yapmamızı sağlayan kontrol kod bloğudur.*/
                if (flipper.isFlipping())
                    flipper.stopFlipping();
                if(ilk.isPlaying())
                {
                    ilk.pause();
                }
                else if(kis.isPlaying())
                {
                    kis.pause();
                }
                else if(yaz.isPlaying())
                {
                    yaz.pause();
                }
                else if(son.isPlaying()) {
                    son.pause();
                }
                /* flipper.showPrevious(), Durdurma işlemleri tamamlandıktan sonra geri giden koddur.*/
                flipper.showPrevious();

                break;

            case R.id.bIleriGit:

                // eğer çalışıyorsa önce durduruyoruz
                if (flipper.isFlipping()) {
                    flipper.stopFlipping();
                }
                if(ilk.isPlaying())
                {
                    ilk.pause();
                }
                else if(kis.isPlaying())
                {
                    kis.pause();
                }
                else if(yaz.isPlaying())
                {
                    yaz.pause();
                }
                else if(son.isPlaying()) {
                    son.pause();
                }

                /* flipper.showNext(), Durdurma işlemleri tamamlandıktan sonra ileri giden koddur.*/
                flipper.showNext();
                break;

            case R.id.bOtomatik:

                // Görsellerin 7 saniyede otomatik olarak değişmesini sağlıyoruz.

                flipper.setFlipInterval(7000);
                flipper.startFlipping();
                break;
        }

    }
}
