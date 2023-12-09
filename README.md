# pink-dream
- Just a stupid name for my first platform game ;-;

- I have added two levels, a starting screen, and an ending screen to the game, which is a Mario-like platform game. I chose strawberries as collectible items, and there are also some traps such as saws and spikes. If the player touches these traps, the game restarts.

- I made various adjustments to the player movement script and learned and implemented several features for jumping, walking, and moving with the walking platform. Additionally, I explored and applied sound effects to enhance the gaming experience.

- I consider these developments a good start for my first fully completed game.

## Github yükleme adımları: 
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

