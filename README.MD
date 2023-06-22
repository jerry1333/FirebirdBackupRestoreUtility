# Firebird Backup and Restore Tool
The third version of Firebird introduces a new database structure (ODS - On Disk Structure) and only supports it. This means that databases created with previous versions have become unreadable for the third version. Therefore, if you want to migrate a database from previous releases, you must first back up the database and then restore it from that backup using the v3 utilities.

ODS version is connected to Firebird server version:

| Firebird version | ODS version |
| ---------------- | ----------- |
| Firebird 1.0     | 10.0        |
| Firebird 1.5     | 10.1        |
| Firebird 2.0     | 11          |
| Firebird 2.1     | 11.1        |
| Firebird 2.5     | 11.2        |
| Firebird 3.0     | 12          |

---

## How to check current ODS
Run this tool and select valid database.

ODS will be printeg in log window and saved in log file.

---

## How to convert database to new ODS
1. Run the 'FBBack.exe' application

2. Backup (backup) - on a computer with Firebird 2.5:
2.1. Check 'Backup' and 'Repair scripts'
2.2. Use the 'Select files' button to select database files (we recommend moving the databases to the directory with the 'fbback' application; you can select multiple databases)
2.3. In the 'Login' and 'Password' fields, enter the login details of the database user
2.4. Press 'Start' to start the backup procedure - the copy will be created in the same location

3. Restore (restore from backup) - after uninstalling Firebird 2.5 and installing Firebird 3
3.1. In the 'FBBack.exe' application, select 'Restore'
3.2. Use the 'Select files' button to indicate files with a copy of the databases
3.3. In the 'Login' and 'Password' fields, enter the login details of the database user
3.4. Click 'Start' to start the restore procedure - the target database files will be created in the same location

---



