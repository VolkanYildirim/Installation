package firma.eglenerekogreniyorum;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ImageButton;
import android.widget.Toast;

//Ekranda birden fazla tıklama olacağı için View.OnClickListener implements ediyoruz.
public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    //Ekranda görünen 6 adet resim birer imagebutton onların tanımlamalarını yapıyoruz.
    ImageButton rakamlar, mevsimler, cikis, sekiller, hakkinda, sarkilar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        //nesnetanimlar adında bir metot oluşturuyoruz.
        nesnetanimlar();
        
    }

    /*
    * Projede bazı kod satırları tekrar ediyor. Bu kod satırlarını daha önce açıkladığımız için tekrar eden yerlerde açıklama ihtiyacı duymadık.
    * Projenin apk dosyası için üst sekmeden Build e tıkla, Build APK seçeneği üzerinden devam edebilirsin.
    * Projenin ismi, logosunu güncellemek isteyebilirsin. Values klasörüne gidip strings.xml dosyasını açabilir, proje adını değiştirebilirsin.
    * Logo için, Mipmap klasörü içine istediğin logoyu ekleyip Manifest dosyasında android:icon="@mipmap/ ifadesinden sonra yeni logonun adını yazarak uygulamanın logosunu güncelleyebilirsin.
    * Herhangi bir yerde anlaşılmazlık olduysa cep telefonumdan ya da helloWorld yazılım Instagram adresinden bizlere ulaşabilirsin. İyi çalışmalar.
    */

    private void nesnetanimlar() {

        //Burada tanımladığımız imagebutonları belirlediğim id'ler ile eşleştirip onların tıklama özelliklerini aktif ediyoruz.
        sarkilar = (ImageButton) findViewById(R.id.sarkilar);
        sarkilar.setOnClickListener(this);

        rakamlar = (ImageButton) findViewById(R.id.rakamlar);
        rakamlar.setOnClickListener(this);

        mevsimler = (ImageButton) findViewById(R.id.mevsimler);
        mevsimler.setOnClickListener(this);

        sekiller = (ImageButton) findViewById(R.id.sekiller);
        sekiller.setOnClickListener(this);

        hakkinda = (ImageButton) findViewById(R.id.hakkinda);
        hakkinda.setOnClickListener(this);

        cikis = (ImageButton) findViewById(R.id.cikis);
        cikis.setOnClickListener(this);

    }

    //Birden fazla tıklama yapıcağımız için bu metotu ekledik
    @Override
    public void onClick(View view) {

        //switch ile id'leri alıp onlara göre işlem yapıyoruz.
        switch (view.getId()) {

            //her case bir durumu ifade etmektedir.Burda id'si sarkilar olan resime tıklanınca yapılacaklar yazılmıştır.
            case R.id.sarkilar:

                //Intent niyet anlamındadır sıklıkla sayfalar arası geçiş için kullanılır burada ki kullanım amacı bu.
                // Bu kod ile Sarkilar sayfasına geçiş yapıyoruz.
                Intent sarkilar = new Intent(MainActivity.this, Sarkilar.class);
                startActivity(sarkilar);
                break;

            case R.id.rakamlar:
                Intent rakamlar = new Intent(MainActivity.this, Rakamlar.class);
                startActivity(rakamlar);
                break;

            case R.id.mevsimler:
                Intent mevsim = new Intent(MainActivity.this, Mevsimler.class);
                startActivity(mevsim);
                break;

            case R.id.hakkinda:
                Intent hakkinda = new Intent(MainActivity.this, Hakkinda.class);
                startActivity(hakkinda);
                break;

            case R.id.sekiller:
                Intent sekiller = new Intent(MainActivity.this, Sekiller.class);
                startActivity(sekiller);
                break;

            case R.id.cikis:
                Toast.makeText(MainActivity.this, "Uygulamadan çıkış yaptınız.", Toast.LENGTH_SHORT).show();
                Intent intent = new Intent(Intent.ACTION_MAIN);
                intent.addCategory(Intent.CATEGORY_HOME);
                intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                startActivity(intent);
                break;

        }

    }
}
