import requests
import sqlite3
import json
# URL to get JSON data from
url = " https://cdn.cookielaw.org/consent/e962d8c8-d4a3-459a-a6f4-d9c01dbac777/e962d8c8-d4a3-459a-a6f4-d9c01dbac777.json"

# Send a GET request to the URL
response = requests.get(url)

# Check if the request was successful (status code 200)
if response.status_code == 200:
    # Retrieve the JSON data from the response
    data = response.json()
  #  print(data)
   # Get the classes from the JSON data
    classes = data.keys()
    # Print the classes
    for class_name in classes:
        print(class_name)
# Connect to the SQLite database
    conn = sqlite3.connect("data.db")
    cursor = conn.cursor()

   #insert data in each feild
    id = data.get("id")
    OptanonDataJSON = json.dumps(data.get("OptanonDataJSON"))
    ScriptType = json.dumps(data.get("ScriptType"))
    RuleSet=json.dumps(data.get("RuleSet"))
    Version= data.get("Version")
   

    cursor.execute("INSERT INTO data_table (id, OptanonDataJSON, ScriptType, RuleSet, Version) VALUES (?, ?, ?, ?, ?)",
            (id,OptanonDataJSON, ScriptType,RuleSet, Version))

    # Commit the changes and close the database connection
    conn.commit()
    conn.close()

    print("Data stored in the database successfully.")
else:
    print("Error: Failed to retrieve data from the URL")