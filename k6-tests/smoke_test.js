import http from 'k6/http';

export let options = {
    insecureSkipTLSVerify: true,
    noConnectionReuse: false,
    vus: 1,
    duration: '1m',
    thesholds: {
        http_req_duration: ['p(99)<1500'],
    },
};

const API_URL = 'http://localhost:5000/books';

export default () => {
    var params = {
        headers: { 'Content-Type': 'application/json' },
    };
    http.get(API_URL, params);
}