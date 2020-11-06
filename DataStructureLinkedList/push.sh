read a
git branch $a
git checkout $a
git add Program.cs
git commit -m "[Apoorva] Add . Create a simple Linked List of 56, 30 and 70"
git push origin $a
git checkout master
git merge $a
git push origin master --force
