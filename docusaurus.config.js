// @ts-check
// `@type` JSDoc annotations allow editor autocompletion and type checking
// (when paired with `@ts-check`).
// There are various equivalent ways to declare your Docusaurus config.
// See: https://docusaurus.io/docs/api/docusaurus-config

import {themes as prismThemes} from 'prism-react-renderer';

const organizationName = "lbte";
const projectName = "design-patterns";

/** @type {import('@docusaurus/types').Config} */
const config = {
  title: 'Design Patterns',
  tagline: 'Design Patterns are cool',
  favicon: 'img/logo-dark.png',

  // Set the production url of your site here
  url: `https://${organizationName}.github.io`,
  // Set the /<baseUrl>/ pathname under which your site is served
  // For GitHub pages deployment, it is often '/<projectName>/'
  baseUrl: `/${projectName}/`,

  // GitHub pages deployment config.
  // If you aren't using GitHub pages, you don't need these.
  organizationName, // Usually your GitHub org/user name.
  projectName, // Usually your repo name.


  onBrokenLinks: 'throw',
  onBrokenMarkdownLinks: 'warn',

  // Even if you don't use internationalization, you can use this field to set
  // useful metadata like html lang. For example, if your site is Chinese, you
  // may want to replace "en" with "zh-Hans".
  i18n: {
    defaultLocale: 'en',
    locales: ['en'],
  },

  presets: [
    [
      'classic',
      /** @type {import('@docusaurus/preset-classic').Options} */
      ({
        docs: {
          sidebarPath: './sidebars.js',
          // Please change this to your repo.
          // Remove this to remove the "edit this page" links.
          editUrl: `https://github.com/${organizationName}/${projectName}/tree/main/`,
        },
        blog: {
          showReadingTime: true,
          // Please change this to your repo.
          // Remove this to remove the "edit this page" links.
          editUrl: `https://github.com/${organizationName}/${projectName}/tree/main/`,
        },
        theme: {
          customCss: './src/css/custom.css',
        },
      }),
    ],
  ],

  themeConfig:
    /** @type {import('@docusaurus/preset-classic').ThemeConfig} */
    ({
      // Replace with your project's social card
      colorMode: {
        defaultMode: 'dark'
      },
      image: 'img/docusaurus-social-card.jpg',
      navbar: {
        title: '',
        logo: {
          alt: 'Design Patterns Logo',
          src: 'img/logo.png',
        },
        items: [
          {to: '/docs/creational-patterns/factory-method', label: 'Design Patterns', position: 'left'},
          {to: '/blog', label: 'Blog', position: 'left'},
          {
            href: 'https://github.com/lbte/design-patterns',
            label: 'GitHub',
            position: 'right',
          },
        ],
      },
      footer: {
        style: 'dark',
        links: [
          {
            title: 'Patterns',
            items: [
              {
                label: 'Creational',
                to: '/docs/category/creational-patterns',
              },
              {
                label: 'Structural',
                to: '/docs/category/structural-patterns',
              },
              {
                label: 'Behavioral',
                to: '/docs/category/behavioral-patterns',
              },
            ],
          },
          {
            title: 'Community',
            items: [
              {
                label: 'Stack Overflow',
                href: 'https://stackoverflow.com/questions/tagged/docusaurus',
              },
              {
                label: 'Discord',
                href: 'https://discordapp.com/invite/docusaurus',
              },
              {
                label: 'Twitter',
                href: 'https://twitter.com/docusaurus',
              },
            ],
          },
          {
            title: 'More',
            items: [
              {
                label: 'Blog',
                to: '/blog',
              },
              {
                label: 'GitHub',
                href: 'https://github.com/lbte/design-patterns',
              },
            ],
          },
        ],
        copyright: `Copyright © ${new Date().getFullYear()} lbte, Inc. Built with Docusaurus.`,
      },
      prism: {
        darkTheme: prismThemes.dracula,
        theme: prismThemes.github,
        additionalLanguages: ['csharp'],
      },
    }),
    markdown: {
      mermaid: true,
    },
    themes: ['@docusaurus/theme-mermaid'],
};

export default config;
