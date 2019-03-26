package firma.eglenerekogreniyorum;

import android.media.MediaPlayer;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.MediaController;
import android.widget.VideoView;

public class Rakamlar extends AppCompatActivity implements View.OnClickListener {

    ImageButton bir,iki,uc,dort,bes,alti,yedi,sekiz,dokuz;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_rakamlar);

        //Videoyu oynatan nesne VideoView nesnesidir.Diğer sayfalarda ki gibi id eşleştirmesi yapıyoruz.
        VideoView videoView =(VideoView)findViewById(R.id.videoView);

        //Video oynatma esnasında dur,ilerle,gerile gibi komutları kullanabilmek için MediaController tanımlıyoruz
        //İkinci satır ile onu videomuz ile ilişkilendiriyoruz.
        MediaController mediaController= new MediaController(this);
        mediaController.setAnchorView(videoView);

        //Burada Uri konum belirtmek için kullanılır.Raw klasörü içinde ki x adlı dosyayı eşleştiriyoruz.
        Uri uri = Uri.parse("android.resource://" + getPackageName() + "/" + R.raw.x);
        //Bu satır ile MediaController'ı videomuza atıyoruz.
        videoView.setMediaController(mediaController);
        //Video nesnesine X adlı dosyayı bulunduran uri nesnesini atıyoruz.
        videoView.setVideoURI(uri);
        //Focus özelliğini aktif ediyoruz.
        videoView.requestFocus();
        //Başlatıyoruz.
        videoView.start();

        //tanımlar burada diğer sayfalarda oldugu gibi bir metotdur.
        tanımlar();
        
    }

    private void tanımlar() {

        /* onCreate tarafı çok fazla dolmasın diye tanımlar diye metot oluşturup tüm tanımları içine doldurduk.*/
        bir = (ImageButton) findViewById(R.id.birRakam);
        bir.setOnClickListener(this);
        iki = (ImageButton) findViewById(R.id.ikiRakam);
        iki.setOnClickListener(this);
        uc = (ImageButton) findViewById(R.id.ucRakam);
        uc.setOnClickListener(this);
        dort = (ImageButton) findViewById(R.id.dortRakam);
        dort.setOnClickListener(this);
        bes = (ImageButton) findViewById(R.id.besRakam);
        bes.setOnClickListener(this);
        alti = (ImageButton) findViewById(R.id.altiRakam);
        alti.setOnClickListener(this);
        yedi = (ImageButton) findViewById(R.id.yediRakam);
        yedi.setOnClickListener(this);
        sekiz = (ImageButton) findViewById(R.id.sekizRakam);
        sekiz.setOnClickListener(this);
        dokuz = (ImageButton) findViewById(R.id.dokuzRakam);
        dokuz.setOnClickListener(this);

    }

    @Override
    public void onClick(View view) {


        /* ID bilgisine göre işlem yapıyoruz. */
        switch (view.getId())
        {
            /*her case ifadesi bir durumu ifade eder.*/
            case R.id.birRakam:
                /*raw klasöründeki her medyayı burada butonla ilişkilendiriyoruz. Bu sayede tıklandığında raw klasöründeki ilgili medya işleme geçiyor.*/
                MediaPlayer birr = MediaPlayer.create(Rakamlar.this,R.raw.bir);
                birr.start();
                break;
            case R.id.ikiRakam:
                MediaPlayer ikii = MediaPlayer.create(Rakamlar.this,R.raw.iki);
                ikii.start();
                break;
            case R.id.ucRakam:
                MediaPlayer ucc = MediaPlayer.create(Rakamlar.this,R.raw.uc);
                ucc.start();
                break;
            case R.id.dortRakam:
                MediaPlayer dortt = MediaPlayer.create(Rakamlar.this,R.raw.dort);
                dortt.start();
                break;
            case R.id.besRakam:
                MediaPlayer bess = MediaPlayer.create(Rakamlar.this,R.raw.bes);
                bess.start();
                break;
            case R.id.altiRakam:
                MediaPlayer altii = MediaPlayer.create(Rakamlar.this,R.raw.alti);
                altii.start();
                break;
            case R.id.yediRakam:
                MediaPlayer yedii = MediaPlayer.create(Rakamlar.this,R.raw.yedi);
                yedii.start();
                break;
            case R.id.sekizRakam:
                MediaPlayer sekizz = MediaPlayer.create(Rakamlar.this,R.raw.sekiz);
                sekizz.start();
                break;
            case R.id.dokuzRakam:
                MediaPlayer dokuzz = MediaPlayer.create(Rakamlar.this,R.raw.dokuz);
                dokuzz.start();
                break;
        }

    }
}
