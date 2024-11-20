`use strict`;
function timeConversion(s) {
    let time = s.slice(0, 8);
    let period = s.slice(8, 10);
    let [hours, minutes, seconds] = time.split(':');
    let convertedTime = '';
    if (period === 'AM') {
        if (hours === '12') {
            hours = '00';
        }
    } else {
        if (hours !== '12') {
            hours = parseInt(hours, 10) + 12;
        }
    }
    convertedTime = `${hours}:${minutes}:${seconds}`;
    return convertedTime;
}

console.log(timeConversion("07:05:45PM"));