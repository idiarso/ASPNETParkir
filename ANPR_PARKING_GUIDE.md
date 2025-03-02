# Sistem Manajemen Parkir dengan ANPR

Sistem manajemen parkir modern dengan fitur Automatic Number Plate Recognition (ANPR) untuk mengelola parkir kendaraan secara efisien.

## Daftar Isi
- [Pendahuluan](#pendahuluan)
- [Fitur Utama](#fitur-utama)
- [Panduan Pengguna](#panduan-pengguna)
  - [Panduan untuk Petugas Parkir](#panduan-untuk-petugas-parkir)
  - [Panduan untuk Admin](#panduan-untuk-admin)
- [Instalasi](#instalasi)
- [Konfigurasi](#konfigurasi)
- [Pemeliharaan](#pemeliharaan)
- [ANPR & Pencocokan Gambar](#anpr--pencocokan-gambar)
- [Spesifikasi Sistem](#spesifikasi-sistem)

## Pendahuluan

Sistem Manajemen Parkir dengan ANPR adalah solusi modern untuk mengelola area parkir dengan efisien. Sistem ini menggunakan teknologi pengenalan plat nomor otomatis (ANPR) untuk mencatat kendaraan yang masuk dan keluar, serta dilengkapi dengan berbagai fitur manajemen dan pelaporan.

## Fitur Utama

- **Pengenalan Plat Nomor Otomatis (ANPR)**
  - Deteksi otomatis plat nomor kendaraan
  - Akurasi tinggi dalam berbagai kondisi pencahayaan
  - Dukungan untuk berbagai format plat nomor

- **Manajemen Parkir Real-time**
  - Monitor ketersediaan slot parkir
  - Tracking kendaraan masuk/keluar
  - Notifikasi real-time

- **Sistem Pembayaran Digital**
  - Integrasi dengan berbagai metode pembayaran
  - Perhitungan tarif otomatis
  - Manajemen transaksi

- **Pelaporan dan Analitik**
  - Laporan okupansi
  - Analisis pendapatan
  - Statistik penggunaan

- **Manajemen Pengguna**
  - Multi-level akses
  - Manajemen petugas
  - Audit trail

- **Backup dan Restore Data**
  - Backup otomatis
  - Restore point
  - Ekspor data

- **Log Aktivitas**
  - Tracking aktivitas sistem
  - Log keamanan
  - Audit trail

- **Dashboard Interaktif**
  - Visualisasi data real-time
  - Grafik dan statistik
  - Monitoring sistem

## Panduan Pengguna

### Panduan untuk Petugas Parkir

#### 1. Login ke Sistem
- Buka aplikasi di browser
- Masukkan username dan password yang diberikan
- Klik tombol "Masuk"

#### 2. Mencatat Kendaraan Masuk
- Di halaman utama, klik "Kendaraan Masuk"
- Arahkan kamera ke plat nomor kendaraan
- Sistem akan otomatis mendeteksi plat nomor
- Verifikasi hasil deteksi
- Pilih jenis kendaraan
- Klik "Simpan" untuk mencetak tiket

#### 3. Mencatat Kendaraan Keluar
- Scan tiket parkir atau masukkan nomor tiket
- Sistem akan menampilkan informasi kendaraan
- Verifikasi plat nomor kendaraan
- Sistem akan menghitung biaya parkir
- Proses pembayaran:
  - Pilih metode pembayaran
  - Masukkan jumlah yang diterima
  - Klik "Proses Pembayaran"
  - Cetak struk pembayaran

#### 4. Menangani Kasus Khusus
- Tiket Hilang:
  - Klik "Tiket Hilang"
  - Masukkan plat nomor kendaraan
  - Verifikasi dengan foto kendaraan
  - Proses sesuai prosedur tiket hilang
- Kendaraan Menginap:
  - Gunakan menu "Kendaraan Menginap"
  - Ikuti prosedur tarif menginap

#### 5. Laporan Harian
- Di akhir shift, buka menu "Laporan Shift"
- Verifikasi semua transaksi
- Cetak laporan shift
- Serahkan ke supervisor

### Panduan untuk Admin

#### 1. Dashboard Admin
- Akses Dashboard:
  - Login sebagai admin
  - Lihat statistik real-time:
    - Jumlah kendaraan
    - Pendapatan
    - Slot tersedia
    - Grafik tren

#### 2. Manajemen Pengguna
- Menambah Pengguna Baru:
  - Buka menu "Kelola Pengguna"
  - Klik "Tambah Pengguna"
  - Isi informasi:
    - Username
    - Password
    - Role (Admin/Petugas)
    - Informasi pribadi
  - Klik "Simpan"
- Mengelola Pengguna:
  - Edit informasi pengguna
  - Reset password
  - Nonaktifkan akun
  - Atur hak akses

#### 3. Manajemen Parkir
- Pengaturan Tarif:
  - Buka menu "Pengaturan Tarif"
  - Atur tarif berdasarkan:
    - Jenis kendaraan
    - Durasi
    - Tarif khusus
- Manajemen Slot:
  - Atur jumlah slot
  - Monitor okupansi
  - Atur zona parkir

#### 4. Laporan dan Analisis
- Laporan Keuangan:
  - Buka menu "Laporan"
  - Pilih jenis laporan
  - Atur periode
  - Export ke Excel/PDF
- Analisis Data:
  - Lihat tren parkir
  - Analisis pendapatan
  - Monitor kinerja sistem

#### 5. Backup dan Maintenance
- Backup Data:
  - Buka menu "Backup"
  - Pilih jenis backup
  - Atur jadwal backup
  - Download/restore backup
- Log Aktivitas:
  - Monitor aktivitas sistem
  - Filter log berdasarkan:
    - Waktu
    - Pengguna
    - Jenis aktivitas
  - Export log

#### 6. Pengaturan Sistem
- Konfigurasi Umum:
  - Pengaturan aplikasi
  - Konfigurasi printer
  - Pengaturan kamera
  - Integrasi sistem
- Keamanan:
  - Atur kebijakan password
  - Monitor login gagal
  - Atur backup otomatis

## ANPR & Pencocokan Gambar

### Spesifikasi Kamera
- Resolusi minimal: 2MP
- Frame rate: 30 fps
- Infrared night vision
- Weather-resistant (IP66)
- Koneksi: TCP/IP

### Persyaratan Pencahayaan
- Pencahayaan minimal: 100 lux
- Rekomendasi: 200-300 lux
- Hindari backlight langsung

### Posisi Kamera
- Ketinggian: 2-2.5 meter
- Sudut: 15-30 derajat
- Jarak: 3-5 meter dari titik deteksi

### Spesifikasi Perangkat Lunak ANPR
- Akurasi deteksi: >95%
- Waktu proses: <1 detik
- Format plat yang didukung: Semua format plat Indonesia
- Penyimpanan gambar: JPEG/PNG

## Spesifikasi Sistem

### Persyaratan Server
- CPU: Intel Xeon atau setara
- RAM: 16GB minimum
- Storage: SSD 256GB minimum
- OS: Windows Server 2019 atau Linux

### Persyaratan Jaringan
- Bandwidth minimal: 10Mbps
- Latency maksimal: 100ms
- Koneksi redundant

### Database
- SQL Server atau PostgreSQL
- Backup harian
- Retention policy: 90 hari

### Keamanan
- SSL/TLS encryption
- Firewall
- Regular security updates
- Access control
- Data encryption

### Integrasi
- REST API
- Webhook support
- Database replication
- Third-party payment gateway