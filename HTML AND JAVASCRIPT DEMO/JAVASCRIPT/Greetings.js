var dtime = new Date();
        var dayTime = dtime.getHours();
        document.writeln("<h2>Current Hours :" + dtime.getHours() + "</h2>");
        document.writeln("<h1>");
        if (dtime.getHours() >= 0 && dtime.getHours() < 12) {
            document.write("GOOD MORNING");
        }
        else if (dtime.getHours() >= 12 && dtime.getHours() < 13) {
            document.write("GOOD NOON");
        }
        else if (dtime.getHours() >= 13 && dtime.getHours() < 16) {
            document.write("GOOD AFTERNOON");
        }
        else if (dtime.getHours() >= 16 && dtime.getHours() < 24) {
            document.write("GOOD EVENING");
        }
        else {
            document.write("GOOD DAY");
        }
        document.writeln("</h1>");