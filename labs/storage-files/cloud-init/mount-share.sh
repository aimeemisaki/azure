#!/bin/bash

# *** replace these with your actual SA name and key:
ACCOUNT_NAME='afsaimi'
ACCOUNT_KEY='uYseYEyK6f0THDyJJ7CzeQpu5G54e30bqBr076tqgg1NkGN0M6jn4pW74XGvGoej5GFND0akx4Yp+AStS8mwbw=='
# ***

CONTAINER_NAME='labs'
SMB_FILE='/etc/smbcredentials/azure-files.cred'

mkdir -p /mnt/labs
mkdir -p /etc/smbcredentials
touch $SMB_FILE

echo "username=$ACCOUNT_NAME" > $SMB_FILE
echo "password=$ACCOUNT_KEY" >> $SMB_FILE
chmod 600 $SMB_FILE

echo "//$ACCOUNT_NAME.file.core.windows.net/$CONTAINER_NAME /mnt/$CONTAINER_NAME cifs nofail,credentials=$SMB_FILE,dir_mode=0777,file_mode=0777,serverino,nosharesock,actimeo=30" >> /etc/fstab
mount -t cifs "//$ACCOUNT_NAME.file.core.windows.net/labs" "/mnt/$CONTAINER_NAME" -o credentials=$SMB_FILE,dir_mode=0777,file_mode=0777,serverino,nosharesock,actimeo=30