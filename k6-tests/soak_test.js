import http from 'k6/http';

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    stages: [
        { duration: '2m', target: 400 },
        { duration: '3h56m', target: 400 },
        { duration: '2m', target: 0 },
    ],
};

const API_URL = 'http://localhost:5000/books';

export default () => {
    var params = {
        headers: { 'Content-Type': 'application/json' },
    };
    http.get(API_URL, params);
}