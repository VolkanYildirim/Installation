package firma.eglenerekogreniyorum;

import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.CompoundButton;
import android.widget.ToggleButton;

public class Sarkilar extends AppCompatActivity {

    /*ToogleButton, açılıp kapanan düğme gibi düşünülebilir. Her iki durumda da olayları mevcuttur. Aşağıda detaylandırılmıştır.*/
    ToggleButton sarki1Btn,sarki2Btn,sarki3Btn,sarki4Btn;
    MediaPlayer sarki1,sarki2,sarki3,sarki4;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sarkilar);
        tanımlar();

        /*sarki1Btn, bir ToggleButton dur ve değişme olayları tanımlanmıştır. */
        sarki1Btn.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {

                /*Eğer tıklandıysa, aktif edildiyse şarkı başlayacak, */
                if (isChecked){
                    sarki1.start();
                }
                /*Eğer tıklanmadıysa ya da durumu değiştiyse şarkı duracak. */
                else {
                    sarki1.stop();
                }
            }
        });

        sarki2Btn.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked){
                    sarki2.start();
                }
                else {
                    sarki2.stop();
                }
            }
        });

        sarki3Btn.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked){
                    sarki3.start();
                }
                else {
                    sarki3.stop();
                }
            }
        });

        sarki4Btn.setOnCheckedChangeListener(new CompoundButton.OnCheckedChangeListener() {
            @Override
            public void onCheckedChanged(CompoundButton buttonView, boolean isChecked) {
                if (isChecked){
                    sarki4.start();
                }
                else {
                    sarki4.stop();
                }
            }
        });

    }

    private void tanımlar() {

        sarki1 = MediaPlayer.create(Sarkilar.this,R.raw.pazara_gidelim);
        sarki2 = MediaPlayer.create(Sarkilar.this,R.raw.canim_ogretmenim);
        sarki3 = MediaPlayer.create(Sarkilar.this,R.raw.bak_postaci_geliyor);
        sarki4 = MediaPlayer.create(Sarkilar.this,R.raw.yumurta_kafa);
        sarki1Btn = (ToggleButton) findViewById(R.id.sarkibir_oynat);
        sarki2Btn = (ToggleButton) findViewById(R.id.sarkiki_oynat);
        sarki3Btn = (ToggleButton) findViewById(R.id.sarkiuc_oynat);
        sarki4Btn = (ToggleButton) findViewById(R.id.sarkidort_oynat);

    }
}
