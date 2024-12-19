Bugs trouvés dans Unity :
 -Le niveau tombe au lancement : Il fallait passer le niveau en static

 -Le texte HP ne suit pas le joueur : Il ne lui était pas assigné dans l'éditeur Unity

 -Erreur sur la scale du sol : Passer la scale de -70 à 70 car les valeurs négatives ne sont pas supportées

 -Pourquoi le canvas du score il est comme ça ? : Je l'ai replacé à une position qui me paraissait plus correcte en passant ses paramètres en world space plutôt que screen space

 -On avait pas le bon box collider sur le sol tout en bas + passage du sol en static.

 -J'ai freeze la rotation en Z du joueur pour qu'il ne se mette pas à rouler

 -Ajout de RigidBody2D aux plateformes pour faire fonctionner le saut.

 -Ajout de RigidBody 2D aux Bumpers pour les faire fonctionner

 -Attribution des bonnes animations aux boss

 -Le saut y'a comme un petit problème