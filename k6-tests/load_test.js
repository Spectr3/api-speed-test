import http from 'k6/http';

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    stages: [
        { duration: '5m', target: 100 },
        { duration: '10m', target: 100 },
        { duration: '5m', target: 0 },
    ],
    thesholds: {
        http_req_duration: ['p(99)<150'],
    },
};

const API_URL = 'http://localhost:5000/books';

export default () => {
    var params = {
        headers: { 'Content-Type': 'application/json' },
    };
    http.get(API_URL, params);
}