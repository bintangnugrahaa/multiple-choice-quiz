# Kuis Pilihan Ganda

Proyek ini adalah gim kuis ringan berbasis Unity yang menampilkan serangkaian pertanyaan pilihan ganda dengan indikator benar/salah, sistem skor sederhana, dan latar audio untuk menjaga suasana bermain tetap menarik.

## Fitur Utama

- **Navigasi pertanyaan berantai** - setiap panel soal dinonaktifkan setelah dijawab dan otomatis berpindah ke soal berikutnya.
- **Umpan balik langsung** - elemen `feed_benar` dan `feed_salah` memberikan visual cue sesaat sebelum lanjut ke pertanyaan berikutnya.
- **Skor tersinkronisasi** - skor tersimpan di `PlayerPrefs` agar dapat dibaca lintas UI secara real-time.
- **Transisi scene cepat** - skrip `SceneManager` khusus mempermudah pemanggilan `LoadScene` dari tombol UI.
- **Musik latar berkelanjutan** - komponen `BGM` memastikan lagu tetap berjalan antar scene menggunakan `DontDestroyOnLoad`.

## Persyaratan

- Unity **6000.2.13f1** atau versi yang kompatibel (lihat `ProjectSettings/ProjectVersion.txt`).
- Modul Build sesuai platform target (Android, Windows, dsb) jika ingin melakukan ekspor.

## Struktur Folder Singkat

- `Assets/` - skrip inti (`jawab.cs`, `skor.cs`, `LoadScene.cs`, `bgm.cs`), aset grafis, audio, dan font.
- `Assets/Scenes/` - scene utama kuis beserta varian menu (lihat file `.unity`).
- `Assets/TextMesh Pro/` - paket TMP standar untuk teks kaya.
- `ProjectSettings/` & `Packages/` - konfigurasi project Unity.
- `Library/`, `Logs/`, `UserSettings/` - folder auto-generated oleh Unity (tidak perlu versi kontrol).

## Cara Menjalankan

1. Buka Unity Hub, pilih **Open**, dan arahkan ke folder `Kuis Pilihan Ganda`.
2. Setelah Unity selesai memuat, buka scene awal kuis di `Assets/Scenes/`.
3. Tekan **Play** di Editor untuk mencoba.

## Alur Permainan

1. Scene awal menginisialisasi skor menjadi `0`.
2. Pemain memilih jawaban pada setiap panel:
   - Jawaban benar menambah skor **10 poin** dan menampilkan `feed_benar`.
   - Jawaban salah memunculkan `feed_salah`.
3. Setelah penundaan 1 detik, panel soal saat ini tersembunyi dan panel berikutnya aktif.
4. Musik latar diputar secara kontinu selama sesi bermain.

## Kustomisasi Cepat

- Ubah teks pertanyaan atau opsi langsung dari GameObject UI di scene.
- Tambahkan panel baru dengan menggandakan prefab pertanyaan dan menyesuaikan urutan child.
- Sesuaikan skor per jawaban di `jawab.cs` pada bagian `PlayerPrefs.SetInt("skor", skor);`.
- Ganti musik dengan menyeret file audio baru ke `Assets/` dan menghubungkannya ke GameObject yang memuat skrip `BGM`.

## Lisensi Aset

Pastikan Anda memiliki hak penggunaan untuk font, gambar, dan audio yang disertakan (`calibri*.ttf`, `bgm.mp3`, `star.mp3`, `tungg.mp3`, dll.). Ganti dengan aset milik sendiri jika perlu distribusi publik.

Selamat mengembangkan dan selamat bermain!
