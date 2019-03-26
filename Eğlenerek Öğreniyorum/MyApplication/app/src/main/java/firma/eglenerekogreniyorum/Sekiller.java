package firma.eglenerekogreniyorum;

import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.ViewFlipper;

public class Sekiller extends AppCompatActivity implements View.OnClickListener  {

    Button geriGit, ileriGit, otomatik;
    ViewFlipper flipper;

    MediaPlayer birr ,ikii,ucc,dortt,bess,altii;
    ImageButton bir,iki,uc,dort,bes,alti;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sekiller);

        geriGit = (Button) findViewById(R.id.bGeriGit);
        ileriGit = (Button) findViewById(R.id.bIleriGit);
        otomatik = (Button) findViewById(R.id.bOtomatik);
        flipper = (ViewFlipper) findViewById(R.id.vfFlipper);

        geriGit.setOnClickListener(this);
        ileriGit.setOnClickListener(this);
        otomatik.setOnClickListener(this);

        birr=MediaPlayer.create(Sekiller.this,R.raw.ucgen);
        bir=(ImageButton)findViewById(R.id.imagebutton11);
        ikii=MediaPlayer.create(Sekiller.this,R.raw.kare);
        iki=(ImageButton)findViewById(R.id.imagebutton12);
        ucc=MediaPlayer.create(Sekiller.this,R.raw.daire);
        uc=(ImageButton)findViewById(R.id.imagebutton13);
        dortt=MediaPlayer.create(Sekiller.this,R.raw.kalp);
        dort=(ImageButton)findViewById(R.id.imagebutton14);
        bess=MediaPlayer.create(Sekiller.this,R.raw.yildiz);
        bes=(ImageButton)findViewById(R.id.imagebutton15);
        altii=MediaPlayer.create(Sekiller.this,R.raw.dikdortgen);
        alti=(ImageButton)findViewById(R.id.imagebutton16);


        bir.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                birr.start();
            }});
        iki.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ikii.start();

            }
        });
        uc.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                ucc.start();

            }
        });
        dort.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                dortt.start();

            }
        });
        bes.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                bess.start();

            }
        });
        alti.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                altii.start();

            }
        });

    }

    @Override
    public void onClick(View view) {

        switch (view.getId()) {
            case R.id.bGeriGit:

                // eğer çalışıyorsa önce durduruyoruz
                if (flipper.isFlipping())
                    flipper.stopFlipping();
                if(birr.isPlaying())
                {
                    birr.pause();
                }
                else if(ikii.isPlaying())
                {
                    ikii.pause();
                }
                else if(ucc.isPlaying())
                {
                    ucc.pause();
                }
                else if(dortt.isPlaying()) {
                    dortt.pause();
                }
                else if(bess.isPlaying()) {
                    bess.pause();
                }
                else if(altii.isPlaying()) {
                    altii.pause();
                }

                flipper.showPrevious();

                break;

            case R.id.bIleriGit:

                // eğer çalışıyorsa önce durduruyoruz
                if (flipper.isFlipping())
                    flipper.stopFlipping();
                if(birr.isPlaying())
                {
                    birr.pause();
                }
                else if(ikii.isPlaying())
                {
                    ikii.pause();
                }
                else if(ucc.isPlaying())
                {
                    ucc.pause();
                }
                else if(dortt.isPlaying()) {
                    dortt.pause();
                }
                else if(bess.isPlaying()) {
                    bess.pause();
                }
                else if(altii.isPlaying()) {
                    altii.pause();
                }
                flipper.showNext();
                break;

            case R.id.bOtomatik:

                // 7 saniyede otomatik olarak değişmesini sağlıyoruz

                flipper.setFlipInterval(7000);
                flipper.startFlipping();
                break;
        }

    }

}

