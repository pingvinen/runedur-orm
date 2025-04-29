/**
 * @type {import('semantic-release').GlobalConfig}
 */
export default {
    branches: ['main'],
    plugins: [
        [
            "@semantic-release/commit-analyzer",
            {
                "releaseRules": [
                    {"type": "chore", "release": "patch"},
                ],
            }
        ],
        '@semantic-release/release-notes-generator',
        [
            "@semantic-release/exec",
            {
                "prepareCmd": "./version.sh ${nextRelease.version}",
            }
        ],
        [
            '@semantic-release/git',
            {
                message: 'chore(release): v${nextRelease.version}',
            },
        ],
        '@semantic-release/github',
    ],
};
