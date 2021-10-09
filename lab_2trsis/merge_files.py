import os

path = os.getcwd()
file_list = list(os.listdir(path))
# filenames = [f for dp, dn, filenames in os.walk(path) for f in filenames]
filenames = [os.path.join(dp, f) for dp, dn, filenames in os.walk(path) for f in filenames]

print("\n", "<--    start merge     -->", "\n")

for filename in filenames:

    if filename[-3:] != '.py' \
            and filename != 'merge_files.txt' \
            and filename.find('.') != -1 \
                                        \
            and filename[-5:] == '.java' \
            or filename[-3:] == '.kt':

        filename = filename.replace(path, '')
        print("\t processing file : ", filename)

        with open(path+"/"+filename, 'r', encoding='utf-8') as textfile, \
                open(path+"/merge_files.txt", 'a', encoding='utf-8') as textfile_new:
        # with open(path+"/"+filename, 'rb',) as textfile, \
        #         open(path+"/merge_files.txt", 'ab') as textfile_new:

            textfile_new.write("// @filename "+filename+"\n")

            for line in textfile:
                new_line = line
                # if new_line == '\n':
                #     new_line = ''
                #     continue
                textfile_new.write(new_line)

            textfile_new.write("\n\n")

    else:
        continue

print("\n", "<-- successfully merge -->", "\n")
