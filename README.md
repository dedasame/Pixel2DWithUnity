# pink-dream

## Github yükleme adimlari: 
- Unity projesini github a yüklemek için kullanılan bash kodları
### Dosyanın bulunduğu konumda git bash açıyoruz:
```
git add .
git commit -m "Kaydedilmemiş değişiklikler"
```
- git yorumu istenilen şekilde değiştirilir. (Kaydedilmemiş Değişiklikler)

### git geçmişini temizlemek için: yüklerken sorun cıkaran dosyayı temizlemek icin:

```
git filter-branch --force --index-filter \
'git rm --cached --ignore-unmatch Library/PackageCache/com.unity.burst@1.8.4/.Runtime/libburst-llvm-14.dylib' \
--prune-empty --tag-name-filter cat -- --all
```

### güncellenmiş geçmişi uzak depoya itmek için:

```
git push origin --force --all
```


